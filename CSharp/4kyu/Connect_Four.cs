using System;
using System.Collections.Generic;

public class ConnectFour
    {
        public static string WhoIsWinner(List<string> piecesPositionList)
        {
          // Initialize an empty board : 1 = 'R' and 2 = 'Y'
          int[,] board = new int[,] { 
                                    { 0, 0, 0, 0, 0, 0, 0 },
                                    { 0, 0, 0, 0, 0, 0, 0 },
                                    { 0, 0, 0, 0, 0, 0, 0 },
                                    { 0, 0, 0, 0, 0, 0, 0 },
                                    { 0, 0, 0, 0, 0, 0, 0 },
                                    { 0, 0, 0, 0, 0, 0, 0 },
                                    };
                                  
          // Used to convert 'R' and 'Y' respectively to 1 and 2
          Dictionary<char, int> RYTo12 = new Dictionary<char, int>()
                                    { 
                                    { 'R', 1 }, 
                                    { 'Y', 2 } 
                                    };  
          // Used to convert 1 and 2 to "Red" and "Yellow" respectively                      
          Dictionary<int, string> OneTwoToRedYellow = new Dictionary<int, string>()
                                    { 
                                    { 1, "Red" }, 
                                    { 2, "Yellow" } 
                                    };                    
          // Directions to check from each position on the board
          int[][] DIRECTIONS = new int[][] { new int[]{ -1, -1 }, new int[]{ -1, 0 }, new int[]{ -1, 1 }, new int[]{ 0, -1 } };
        
          // Run through picesPositionList and play the moves accordingly
          foreach (string move in piecesPositionList)
          {
            int col = move[0] - 65; // Column the piece has been dropped
            int color = RYTo12[move[2]]; // Player who dropped the piece : 'R' = Red and 'Y' = Yellow
          
          
            // Place the pieces (!!it doesn't not check for exceptions!!)
            int r_place;
            for (r_place = 5; r_place >= 0; r_place--)
            {
              if (board[r_place, col] == 0) // We can place it there
              {
                board[r_place, col] = color; // We change the value of the case
                break;
              }
            }
            
            // Check if this new piece ==> win
            foreach (int[] dir in DIRECTIONS) // Direction to check for four pieces connected
            {
              int dc = dir[0], dr = dir[1]; // Isolate directions coord
              int c_dir = col + dc, r_dir = r_place + dr; // Start going into this direction
              
              
              // Count numbers of pieces connected
              int amount = 1; 
              while (r_dir < 6 && c_dir < 7 && r_dir > 0 && c_dir > 0 && board[r_dir, c_dir] == board[r_place, col] && amount < 4)
              {
                c_dir += dc;
                r_dir += dr;
                amount++;
              }
              
              // Opposite direction
              int c_dir_opp = col - dc, r_dir_opp = r_place - dr;
              while (r_dir_opp < 6 && c_dir_opp < 7 && r_dir_opp >= 0 && c_dir_opp >= 0 && board[r_dir_opp, c_dir_opp] == board[r_place, col] && amount < 4)
              {
                c_dir_opp -= dc;
                r_dir_opp -= dr;
                amount++;
              }
            
              if (amount == 4) // We've a winner!
              {
                return OneTwoToRedYellow[board[r_place, col]];
              }
            }
          }
          return "Draw";
        }
    }
