pragma solidity ^0.4.19;

contract HelloWorld {
  // State Variables
  string greeting = "Hello World!"; // Change this
  
  // Endpoints
  function greet() constant returns (string) {
    return greeting;
  }
  
  function setGreeting(string newGreeting) public {
    greeting = newGreeting;
  }
}