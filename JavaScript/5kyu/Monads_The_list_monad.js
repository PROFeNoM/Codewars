function canReach(from, to, movements) {
    return knightEngine(from, movements).some(x => x[0] === to[0] && x[1] === to[1]);
}

function moveKnight(from) {
    const x = from[0];
    const y = from[1];
    return  [ 
      [ x - 1, y + 2 ], [ x + 1, y + 2 ],
      [ x + 2, y + 1 ], [ x + 2, y - 1 ],
      [ x - 1, y - 2 ], [ x + 1, y - 2 ],
      [ x - 2, y - 1 ], [ x - 2, y + 1 ]
            ].filter(pos => pos[0] > 0 && pos[1] > 0 && pos[0] < 9 && pos[1] < 9);
}

function moveKnightRandom(from) {
    const pos = moveKnight(from);
    return pos[Math.floor(Math.random() * pos.length)];
}

function compose(...fn) {
    return (x) => fn.reverse().reduce((prev, curr) => curr(prev), x);
}

function bind(f) {
    return (a) => a.reduce((prev, curr) => prev.concat(f(curr)), []);
}

function unit(a) {
    return [ a ];
}

function knightEngine(from, movements) {
    return compose(...Array.from({length: movements}, () => bind(moveKnight)), unit)(from);
}