// Задание 3:

// 1. С помощью цикла for выведите в консоль числа от 11 до 33.
// for (let i = 11; i <= 33; i++) {
//     console.log(i);
// }

// 2. С помощью цикла for выведите в консоль нечетные числа в промежутке от 1
// до 100 включительно.
// for (let i = 1; i <= 100; i++) {
//     if (i % 2 !== 0) {
//         console.log(i);
//     }
// }

// for (let i = 1; i <= 100; i += 2) {
//     if (i % 2 !== 0) {
//         console.log(i);
//     }
// }

// 3. С помощью цикла for выведите в консоль числа от 100 до 0.
// for (let i = 100; i >= 0; i--) {
//     console.log(i);
// }

// 4. Создать переменную с заданным числом. Умножайте число на 3 столько раз,
// пока результат умножения не станет больше 1000. Какое число получится?
// Посчитайте количество итераций, необходимых для этого.
// let num = 2;
// let count = 0;
// while (num <= 1000) {
//     num = num * 3;
//     count++;
// }
// console.log(num, count);

// for (num = 2; num <= 1000; num *= 3) {
//     count++;
// }
// console.log(num, count);

// Тайминг: 25 минут.

// Задание 4:

// 1. Создать массив `[2, 5, 9, 15, 1, 4]`.
// Выведите в консоль те элементы массива, которые больше 3-х, но меньше 10.
// const arr = [2, 5, 9, 15, 1, 4];
// for (let i = 0; i < arr.length; i++) {
//     if (arr[i] > 3 && arr[i] < 10) {
//         console.log(arr[i]);
//     }
// }

// arr.forEach(function (num, i) {
//     console.log(num, i);
// });

// arr.forEach(function (num) {
//     if (num > 3 && num < 10) {
//         console.log(num);
//     }
// });

// const filterArr = arr.filter(function (num) {
//     if (num > 3 && num < 10) {
//         return true;
//     }
//     return false;
// });
// console.log(filterArr);

// одинаковый результат
// const filterArr2 = arr.filter(function (num) {
//     return (num > 3 && num < 10);
// });
// console.log(filterArr2);

// const filterArr3 = arr.filter((num) => (num > 3 && num < 10));
// console.log(filterArr3);
// 2. Найдите сумму четных чисел от 2 до 100.
// let sumPositive = 0;
// for (let i = 2; i <= 100; i += 2) {
//     sumPositive += i;
// }
// console.log(sumPositive);
// 3. Создать массив `[2, 5, 9, 3, 1, 4]`.
// Найдите сумму элементов этого массива.
// const array = [2, 5, 9, 3, 1, 4];
// let sumNumber = 0;
// array.forEach(function (num) {
//     sumNumber += num;
// });
// console.log(sumNumber);

// 4. С помощью цикла сформируйте строку '-1-2-3-4-5-6-7-8-9-'.
let result = "-";
for (let i = 1; i <= 9; i++) {
    result += `${i}-`;
}
console.log(result);

// 5. Создать массив `[2, 5, 9, 0, 3, 1, 4]`.
// Запустите цикл, который будет по очереди выводить элементы этого массива в
// консоль до тех пор, пока не встретится элемент со значением 0. После этого
// цикл должен завершить свою работу.
// const array = [2, 5, 9, 0, 3, 1, 4];
// for (let i = 0; i < array.length; i++) {
//     if (array[i] === 0) {
//         break;
//     }
//     console.log(array[i]);
// }
// Тайминг: 25 минут.

// Задание 5:

// 1. Создать массив из 10 случайных чисел от 0 до 100 включительно.
// Наобходимо вывести в консоль все числа, которые делятся и на 2, и на 3.
// const array = [];
// const resultArray = [];
// for (let i = 0; i < 10; i++) {
//     array[i] = Math.round(Math.random() * 100);
//     if (array[i] % 2 === 0 && array[i] % 3 === 0) {
//         resultArray.push(array[i]);
//     }
// }
// console.log(array);
// console.log(resultArray);

// function getRandomInt(min, max) {
//   return Math.floor(Math.random() * (max - min + 1)) + min;
// }

// const randomNumber = getRandomInt(0, 100);
// console.log(randomNumber);
// 2. Дан массив: `[1, 2, 3, 2, 4, 3, 5, 6, 3, 2, 3]`. Подсчитайте количество
// цифр 3 в этом массиве.
// const array = [1, 2, 3, 2, 4, 3, 5, 6, 3, 2, 3];
// let count = 0;
// for (let i = 0; i < array.length; i++) {
//     if (array[i] === 3) {
//         count++;
//     }
// }
// console.log(count);
// 4. Дан массив: `[1, 2, 3, 4, 5]`.
// С помощью метода splice преобразуйте массив в следующий: [1, 4, 5]
const array = [1, 2, 3, 4, 5];
array.splice(1, 2);
console.log(array);
// Тайминг: 25 минут.
