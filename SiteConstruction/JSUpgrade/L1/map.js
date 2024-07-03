let map = new Map();

map.set("one", "str1");
map.set(2, "two");
map.set(false, "bool");

console.log(map);
console.log(map.get("one"));
console.log(map.get(2));
console.log(map.size);

let map2 = new Map();
map2.set("ex", "new")
    .set("new2", "ex2")
    .set(3, "new4");

console.log(map2);
// console.log(map);