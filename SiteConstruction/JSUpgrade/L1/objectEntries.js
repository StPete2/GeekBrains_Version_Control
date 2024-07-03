const obj = {
    key1: "value1",
    key2: "value2"
};

let map = new Map(Object.entries(obj));
console.log(map);

map.set("Key3", "value3");

let obj2 = Object.fromEntries(map);
console.log(obj2);

// let map2 = new Map(Object.entries(obj2));
// console.log(map2);
