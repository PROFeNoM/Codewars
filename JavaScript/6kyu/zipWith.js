function zipWith(fn,a0,a1) {
  return Array.from({ length: Math.min(a0.length, a1.length) }, (_, i) => fn(a0[i], a1[i]));
}