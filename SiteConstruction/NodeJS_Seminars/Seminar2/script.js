const calcResult = require('./calcResult');
// const { calculateResultSum } = require('./calcResult');
const colors = require('colors');
require('colors');

const total = calcResult.calculateResultSum([12.1, 32.2, 43.1], 0.9);
// const total2 = calculateResultSum([12.1, 32.2, 43.1], 0.9);

if (total < 50) {
    console.log(colors.red("Общая стоимость покупок = " + total + " руб."));
} else {
    console.log(colors.green("Общая стоимость покупок = " + total + " руб."));
}

// console.log(total2);
const resultText = "Test string";
console.log(total >= 50 ? resultText.green : resultText.blue);
