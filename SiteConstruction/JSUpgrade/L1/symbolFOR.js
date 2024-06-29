let id = Symbol.for("id");
let idAgain = Symbol.for("id");

console.log(id === idAgain);

let sym = Symbol.for("name");
let sym2 = Symbol.for("id");

console.log(Symbol.keyFor(sym));
console.log(Symbol.keyFor(sym2));
