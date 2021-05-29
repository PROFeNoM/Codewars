function pointVsVector(c, vector){
    const a = vector[0];
    const b = vector[1];
  
    const D = b.map((v, i) => v - a[i]);
    const T = c.map((v, i) => v - a[i]);
  
    return Math.sign(D[1] * T[0] - D[0] * T[1]);
}