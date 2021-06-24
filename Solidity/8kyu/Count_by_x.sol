pragma solidity ^0.4.19;

contract CountByX {

  function countBy(int x, int n) view returns (int[]) {
    int[] z;
    for (int i = 1; i <= n; i++)
      z.push(x * i);
    return z;
  }
}