function chained(functions) {
  return (input) => functions.reduce((prev, curr) => curr(prev), input);
}