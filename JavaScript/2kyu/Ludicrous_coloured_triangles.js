COLOR = {'RR': 'R', 'GG': 'G', 'BB': 'B',
         'BG': 'R', 'RB': 'G', 'RG': 'B',
         'GB': 'R', 'BR': 'G', 'GR': 'B'}

function getBaseLog(x, y) {
  return Math.log(x) / Math.log(y);
}

function triangle(row) {
  const n = row.length;
  if (n == 1)
    return row;
  const d = n - 3 ** Math.floor(getBaseLog(n - 1, 3));
  return COLOR[triangle(row.slice(0, d)) + triangle(row.slice(-d))];
}