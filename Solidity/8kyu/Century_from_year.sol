pragma solidity ^0.4.19;
contract Kata {
  function century(int year) public pure returns (int) {
    return (year + 99) / 100;
  }
}