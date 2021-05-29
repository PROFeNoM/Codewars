function zero(operation) {
  return typeof(operation) === 'undefined' ? 0 : operation(0);
}
function one(operation) {
  return typeof(operation) === 'undefined' ? 1 : operation(1);
}
function two(operation) {
  return typeof(operation) === 'undefined' ? 2 : operation(2);
}
function three(operation) {
  return typeof(operation) === 'undefined' ? 3 : operation(3);
}
function four(operation) {
  return typeof(operation) === 'undefined' ? 4 : operation(4);
}
function five(operation) {
  return typeof(operation) === 'undefined' ? 5 : operation(5);
}
function six(operation) {
  return typeof(operation) === 'undefined' ? 6 : operation(6);
}
function seven(operation) {
  return typeof(operation) === 'undefined' ? 7 : operation(7);
}
function eight(operation) {
  return typeof(operation) === 'undefined' ? 8 : operation(8);
}
function nine(operation) {
  return typeof(operation) === 'undefined' ? 9 : operation(9);
}

function plus(number) {
  return (x) => x + number;
}
function minus(number) {
  return (x) => x - number;
}
function times(number) {
  return (x) => x * number;
}
function dividedBy(number) {
  return (x) => Math.floor(x / number);
}