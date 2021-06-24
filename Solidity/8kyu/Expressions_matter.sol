pragma solidity ^0.4.19;
contract Kata {
  function expressionMatter(int a, int b, int c) public pure returns (int) {
    int[4] memory possibilities 
      = [int(a + b + c), a * b * c, a * (b + c), (a + b) * c];
    int largest = int(possibilities[0]);
    for (uint i = 1; i < 4; i++)
      if (possibilities[i] > largest)
        largest = possibilities[i];
    return largest;
  }
}