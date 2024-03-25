"use strict";

/*
Необходимо создать переменную dayNumber, в которую пользователь должен ввести 
целое число в интервале [1, 32).
Если пользователь ввел иное значение, необходимо вывести в консоль 
"Неверное значение".
Если пользователь ввел верное значение, в нужном диапазоне, то необходимо 
определить, в какую декаду месяца попадает это число и вывести сообщение в 
консоль: "Число N1 попадает в N2 декаду месяца.", где вместо N1 и N2 будут 
подставлены подходящие значения, которые мы получили.

Примечание: выражение [1, 32) означает от 1 включительно, до 32, не включая 
число 32.
*/

const dayNumber = Number(prompt("Введите целое число от 1 до 31 включительно"));
if (dayNumber < 1 || dayNumber > 31 || dayNumber % 1 !== 0) {
    console.log("Неверное значение");
} else {
    /*я буду брать число, делить его на 10.
    Допустим, это от 1 до 9. 
    если после деления на 10 и отбрасывании дробной части получается ноль, то это первая декада.
    если это 1 - это первая декада. и т.д.
    */
    let divisionByTenAndTrunc = Math.trunc(dayNumber / 10);
    if (divisionByTenAndTrunc === 0 || (dayNumber / 10 === 1)) {
        console.log(`Число ${dayNumber} попадает в первую декаду месяца.`);
    } else if (divisionByTenAndTrunc === 1 || (dayNumber / 10 === 2)) {
        console.log(`Число ${dayNumber} попадает во вторую декаду месяца.`);
    } else if (divisionByTenAndTrunc === 2 || (dayNumber / 10 === 3)) {
        console.log(`Число ${dayNumber} попадает в третью декаду месяца.`);
    } else {
        console.log(`Число ${dayNumber} попадает в четвертую декаду месяца.`);
    }
}

