function allContinents(list) {
  const continents = list.map((obj) => obj.continent);
  return continents.filter((c, i) => continents.indexOf(c) === i).length === 5;
}