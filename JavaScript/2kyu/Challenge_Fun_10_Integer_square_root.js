function integerSquareRoot(Number) {
  
    function iSqrt(n) {
        if (n < 2n)
            return n;
      
        const tmp = 2n * iSqrt(n / 4n);
      
        if ((tmp + 1n) ** 2n > n)
            return tmp;
        return tmp + 1n;
    }

    return `${iSqrt(BigInt(Number))}`;
}