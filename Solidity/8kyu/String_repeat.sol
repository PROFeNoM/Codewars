pragma solidity ^0.4.19;

contract Repeater {
  string s;
  
  function append(byte c) public {
    bytes(s).push(c);
  }
  
  function multiply(uint8 repeat, string pattern) returns (string) {
    bytes memory b = bytes(pattern);
    for (uint i = 0; i < repeat; i++)
      for (uint j = 0; j < b.length; j++)
        append(b[j]);
    return s;
  }
}