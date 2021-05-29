function thunk(fn, ...args) {
    return () => fn(...args);
}

function trampoline(thunk) {
    while(typeof thunk === "function")
        thunk = thunk();
    return thunk;
}

function _isOdd(n) {
  return (n === 0 ? false : thunk(_isEven, n - 1));
}
function _isEven(n) {
  return (n === 0 ? true : thunk(_isOdd, n - 1));
}
function isEven(n) {
  return trampoline(thunk(_isEven, n));
}

function isOdd(n) {
  return trampoline(thunk(_isOdd, n));
}