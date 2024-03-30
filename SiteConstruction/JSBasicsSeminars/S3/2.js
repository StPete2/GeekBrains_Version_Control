// Задание 2:
// 1. Создайте функцию, которая параметрами принимает 3 числа и выводит в
// консоль сумму этих чисел.
// Создайте три переменные, со случайными значениями и продемонстрируйте работу
// данной функции.
const sumNumbers = (a, b, c) => {
  console.log(a + b + c);
};

// sumNumbers(2, 3, 5);
sumNumbers(Math.trunc(Math.random() * 10), 4, 5);

// 3. Дан код:

// ```
// func(2);
// func(3);
// func();

// function func(num = 5) {
//   console.log(num * num);
// }
// ```

// Расскажите, каким будет результат каждого из вызовов функции.

// Тайминг: 20 минут.

// Задание 3:

// 1. Создайте функцию, которая принимает число, а возвращает квадратный корень
// переданного числа.
// С помощью созданной функции найдите сумму корней чисел 3 и 4 и выведите данную
// сумму в консоль.
const rootNumber = (x) => Math.sqrt(x);
console.log(rootNumber(4) + rootNumber(3));

// console.log(`Квадратный корень из 64: ${64 ** 0.5}`);
// console.log(`кубический корень из 125: ${125 ** (1 / 3)}`);

// const rootNumber2 = (x) => {
//   return Math.sqrt(x);
// };

// console.log(rootNumber2(25));

// const findMin = (x, y) => Math.min(x, y);
// console.log(findMin(5, 25));

// 2. Создайте функцию, которая находит минимальное число из 2х переданных
// аргументов функции и вернет найденное значение.

// Тайминг: 20 минут.

// Задание 4:

// 1. Создайте функцию, которая принимает параметром число от 1 до 7, а возвращает
// день недели на русском языке.
// const dayNumber = Number(prompt("Введите число от 1 до 7 включительно: "));
// function dayWeek(dayNumber) {
//   switch (dayNumber) {
//     case 1:
//       return "Понедельник";
//     case 2:
//       return "Вторник";
//     case 3:
//       return "Среда";
//     default:
//       return "Воскресенье";
//   }
// }
// console.log(dayWeek(dayNumber));
// const replyFromFunction = dayWeek(dayNumber);
// console.log(replyFromFunction);

// 2. Создайте функцию, которой мы передаем имя и она возвращает приветствие в
// зависимости от времени суток (утро, день, вечер, ночь), например:
// "Добрый день, Иван." или "Доброй ночи, Иван.".

// Тайминг: 30 минут.

// function sayHallo(name) {
//   const date = new Date();
//   console.log(date);
//   console.log(date.getHours());
//   const hour = date.getHours();
//   if (hour >= 0 && hour < 6) {
//     return `Доброй ночи, ${name}.`;
//   } else if (hour >= 6 && hour < 12) {
//     return `Доброе утро, ${name}.`;
//   } else if (hour >= 12 && hour < 18) {
//     return `Добрый день, ${name}.`;
//   } else {
//     return `Добрый вечер, ${name}.`;
//   }
// }

// console.log(sayHallo("Aleksey"));

/**
 * функция возвращает приветствие :-)
 * @param {string} name - имя пользователя
 * @param {number} age - возраст пользователя
 * @returns {string} - строка с приветствием
 */
function sayHallo(name, age) {
  return `Привет, ${name}, Вам ${age}`;
}

