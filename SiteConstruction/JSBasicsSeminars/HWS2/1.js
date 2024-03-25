"use strict";

/*
Создать переменные positive и negative, в которые пользователь вводит с 
клавиатуры значения. Нужно попросить пользователя ввести положительное число в 
переменную positive и отрицательное в переменную negative. 
Перед тем, как положить значения в данные переменные необходимо их превратить 
в числа.
После ввода значений, необходимо вывести "Все значения верные.", если 
пользователь действительно ввел корректные значения, которые мы просили его 
ввести.
Если же пользователь где-то ввел неверное значение, то необходимо вывести 
в консоль "Одно или более значений некорректно.".
*/

const positive = Number(prompt("Введите положительное число (больше нуля)"));
let decision = true;
if (positive <= 0 || Number.isNaN(positive)) {
    decision = false;
}

const negative = Number(prompt("Введите отрицательное число (меньше нуля)"));
if (negative >= 0 || Number.isNaN(negative)) {
    decision = false;
}

if (decision) {
    console.log("Все значения верные.");
} else {
    console.log("Одно или более значений некорректно.");
}