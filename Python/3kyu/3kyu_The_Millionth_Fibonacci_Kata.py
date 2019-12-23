fibs = {0: 0, 1: 1}
def fib(n):
    k = abs(n)
    if n in fibs:
        return fibs[n]
    if -n in fibs:
        return -fibs[k]
        
    if n % 2 == 0:
        fibs[k] = ((2 * fib((k / 2) - 1)) + fib(k / 2)) * fib(k / 2)
        if n<0:
            return -fibs[k]
        else:
            return fibs[n]
    else:
        fibs[k] = (fib((k - 1) / 2) ** 2) + (fib((k+1) / 2) ** 2)
    if n<0:
        return fibs[k]
    return fibs[n]
