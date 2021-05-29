function find_average(array) {
  return array.reduce((prev, curr) => prev + curr, 0) / array.length;
}