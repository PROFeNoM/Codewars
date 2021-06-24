pragma solidity ^0.4.19;
contract Kata {
  function isDivisible(int n, int x, int y) public pure returns (bool) {
    return (n % x == 0) && (n % y == 0);
  }
}