console.log('Текст из script.js!');

const NUM = 123;
console.log(NUM);
let a = 5;
a = 7;
console.log(a);

// let b;
// b = 1 + 2 + 3; 
// console.log(b);
// b = 'text';
// console.log(b);
/* comments */

// const myAge = +prompt("Enter your Age: ");
// const myAge2 = Number.parseInt(prompt("Второй возраст: "));
// console.log(typeof myAge);
const currentYear = 2024;
// const sumMyAgeAndCurrentYear = myAge + currentYear;
// console.log(myAge2);

// console.log(myAge, currentYear);
// console.log(sumMyAgeAndCurrentYear);
// const str = '12a3.2';
// console.log(str);
// console.log(+str);
// console.log(Number(str));
// console.log(Number.parseInt(str));
// console.log(Number.parseFloat(str));

let firstExample = 5 + 5 * 3 + 3;
console.log(firstExample);

const secondVar = 0.1;
const thirdVar = 0.2;
const sumSVTV = secondVar + thirdVar;
//округление числа, превращая его в строку
// console.log(sumSVTV.toFixed(1));
// const toFixedVar = +sumSVTV.toFixed(1);
// console.log(typeof(toFixedVar));

//округляет всегда до целого числа по правилам округления: свыше .5 - вверх, ниже 0.5 - вниз
console.log(Math.round(sumSVTV));

//округляет в меньшую сторону
console.log(Math.floor(sumSVTV));

//всегда вверх
console.log(Math.ceil(sumSVTV));

//убирает дробную часть
console.log(Math.trunc(sumSVTV));

Math.round(sumSVTV * 10) / 10;

const firstName = 'Aleksey';
const lastName = 'Eryukhin';
console.log(`${firstName} ${lastName}`);

console.log(`${firstName} ${lastName}`.toLowerCase());

console.log(`${firstName} ${lastName}`.toLocaleUpperCase());