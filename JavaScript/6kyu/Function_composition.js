function compose(...args) {
  return (a) => args.reverse().reduce((prev, curr) => curr(prev), a);
}