function findSenior(list) {
  const oldestAge = Math.max(...list.map((obj) => obj.age));
  return list.filter((obj) => obj.age == oldestAge);
}