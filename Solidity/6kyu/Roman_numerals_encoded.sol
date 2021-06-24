pragma solidity ^0.4.19;

library StringUtils {
  // Source: https://github.com/Arachnid/solidity-stringutils/blob/master/src/strings.sol
  struct slice {
    uint _len;
    uint _ptr;
  }
    
  function memcpy(uint dest, uint src, uint len) private pure {
    // Copy word-length chunks while possible
    for(; len >= 32; len -= 32) {
      assembly {
        mstore(dest, mload(src))
      }
      dest += 32;
      src += 32;
    }

    // Copy remaining bytes
    uint mask = 256 ** (32 - len) - 1;
    assembly {
      let srcpart := and(mload(src), not(mask))
      let destpart := and(mload(dest), mask)
      mstore(dest, or(destpart, srcpart))
    }
  }
  
  function toSlice(string memory self) internal pure returns (slice memory) {
    uint ptr;
    assembly {
      ptr := add(self, 0x20)
    }
    return slice(bytes(self).length, ptr);
  }
  
  function concat(slice memory self, slice memory other) internal pure returns (string memory) {
    string memory ret = new string(self._len + other._len);
    uint retptr;
    assembly { retptr := add(ret, 32) }
    memcpy(retptr, self._ptr, self._len);
    memcpy(retptr + self._len, other._ptr, other._len);
    return ret;
  }
}

contract Kata {
  using StringUtils for *;
  function solution(uint n) public returns (string) {
    string memory result = "";
    
    uint[13] memory numbers
      = [uint(1000), 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1];
    string[13] memory romanNumeral
      = ["M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"];
    
    for (uint i = 0; i < 13; i++) {
      uint coeff = n / numbers[i];
      if (coeff > 0) {
        for (uint j = 0; j < coeff; j++)
          result = result.toSlice().concat(romanNumeral[i].toSlice());
        n %= numbers[i];
      }
    }
    
    return result;
  }
}