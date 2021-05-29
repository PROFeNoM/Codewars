function compose(n, ...fn) {
    return fn.reduce((prev, curr) => curr(prev), n);
}