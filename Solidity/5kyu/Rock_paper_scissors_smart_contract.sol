pragma solidity >=0.4.19;

contract RockPaperScissors {
  event GameCreated(address creator, uint gameNumber, uint bet);
  event GameStarted(address[] players, uint gameNumber);
  event GameComplete(address winner, uint gameNumber);
  
  enum moveTypes {
    none,
    rock,
    paper,
    scissors
  }
  
  struct Game {
    address payable creator;
    address payable participant;
    uint bet;
    mapping(address => moveTypes) playerMove;
  }
  
  mapping(uint => Game) gamesHistory;
  mapping(uint => bool) gameStarted;
  uint gamePlayed = 0;
  
  /**
  * Use this endpoint to create a game. 
  * It is a payable endpoint meaning the creator of the game will send ether directly to it.
  * The ether sent to the contract should be used as the bet for the game.
  * @param participant - The address of the participant allowed to join the game.
  */
  function createGame(address payable participant) public payable {
    require(msg.value > 0);
    gamesHistory[++gamePlayed] = Game(msg.sender, participant, msg.value);
    gameStarted[gamePlayed] = false;
    emit GameCreated(msg.sender, gamePlayed, msg.value);
  }
  
  /**
  * Use this endpoint to join a game.
  * It is a payable endpoint meaning the joining participant will send ether directly to it.
  * The ether sent to the contract should be used as the bet for the game. 
  * Any additional ether that exceeds the original bet of the creator should be refunded.
  * @param gameNumber - Corresponds to the gameNumber provided by the GameCreated event
  */
  function joinGame(uint gameNumber) public payable {
    require(gameNumber <= gamePlayed);
    require(!gameStarted[gameNumber]);
    Game storage game = gamesHistory[gameNumber];
    require(game.participant == msg.sender);
    require(game.bet <= msg.value);
    if (game.bet < msg.value)
      msg.sender.transfer(msg.value - game.bet);
    address[] memory players = new address[](2);
    players[0] = game.creator;
    players[1] = game.participant;
    gameStarted[gameNumber] = true;
    emit GameStarted(players, gameNumber);
  }
  
  /**
  * Use this endpoint to make a move during a game 
  * @param gameNumber - Corresponds to the gameNumber provided by the GameCreated event
  * @param moveNumber - The move for this player (1, 2, or 3 for rock, paper, scissors respectively)
  */
  function makeMove(uint gameNumber, uint moveNumber) public { 
    require(gameNumber <= gamePlayed);
    require(gameStarted[gameNumber]);
    Game storage game = gamesHistory[gameNumber];
    require(game.creator == msg.sender || game.participant == msg.sender);
    require(1 <= moveNumber && moveNumber <= 3);
    require(game.playerMove[msg.sender] == moveTypes.none);
    
    game.playerMove[msg.sender] = moveTypes(moveNumber);
    moveTypes moveCreator = game.playerMove[game.creator];
    moveTypes moveParticipant = game.playerMove[game.participant];
    address payable gameWinner = address(0);
    if (moveCreator != moveTypes.none && moveParticipant != moveTypes.none) {
      if (uint(moveCreator) % 3 + 1 == uint(moveParticipant))
        gameWinner = game.participant;
      else if (uint(moveParticipant) % 3 + 1 == uint(moveCreator))
        gameWinner = game.creator;
      
      if (gameWinner == address(0)) {
        game.creator.transfer(game.bet / 2);
        game.participant.transfer(game.bet / 2);
      }
      else
        gameWinner.transfer(game.bet);
      
      emit GameComplete(gameWinner, gameNumber);
    }
  }
}