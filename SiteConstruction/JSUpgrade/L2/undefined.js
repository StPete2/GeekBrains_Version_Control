let obj = {
    key: "value",
};

obj = undefined;

console.log(obj?.key); // undefined

let a = null;
let b = 'by default';
console.log(a ?? b);

a = 2;
console.log(a ?? b);

a = null;
b = undefined;

console.log(a ?? b ?? "by default 2");

b = 3;
console.log(a ?? b ?? "by default 3");