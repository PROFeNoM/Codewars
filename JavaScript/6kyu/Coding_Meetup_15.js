function findOddNames(list) {
  return list.filter((obj) => Array.from(obj.firstName).reduce((prev, curr) => prev + curr.charCodeAt(), 0) % 2);
}