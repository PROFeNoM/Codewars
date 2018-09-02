def primeFactors(n):
    i = 2
    factors = list()
    result = ""
    added = list()
    while i <= n:
        if (n % i) == 0:
            factors.append(i)
            n = n / i
        else:
            i = i + 1
    for f in factors:
        if not f in added:
            c = factors.count(f)
            if c == 1:
                result += ("(" + str(f) + ")")
            else:
                result += ("(" + str(f) + "**" + str(c) + ")")
            added.append(f)   
    return result
