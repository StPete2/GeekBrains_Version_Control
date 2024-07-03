let id = Symbol.for("id");
let id2 = Symbol.for("id");
console.log(id === id2);
console.log(Symbol.keyFor(id2));

let id3 = Symbol("id3");

console.log(id3 === id);
console.log(Symbol.keyFor(id3));
console.log(id3.description);