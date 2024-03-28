// Задание 1: 

// 1. Написать функцию, которая принимает, имя, фамилия и возраст. Функция должна 
// вывести в консоль строку: 
// "Привет, `имя` `фамилия`. Вы уже большой, вам `возраст`."
// function getUserData(question) {    
//     const answer = prompt(question);
//     return answer;
// }

// const userName = getUserData('Как Вас зовут?');
// const userLastName = getUserData('Какая Ваша фамилия?');
// const userAge = getUserData('Сколько Вам лет?');

// console.log(`Привет, ${userName} ${userLastName}. Вы уже большой, Вам ${userAge}`);

// 2. Создайте функцию, которая принимает число, а возвращает квадрат переданного
// ей числа.
// const squareOfANumber = (number) => number * number;

// const number = Number.parseInt(prompt('Введите целое число'));
// console.log(squareOfANumber(number));

function squareOfANumber2(x) {
    return x * x;
}
console.log(squareOfANumber2(6));

// 3. Создайте функцию, которая принимает число. 
// Функция должна вывести в консоль '+++', если число положительное, либо '---',
// если число было отрицательное. В случае, если было передано не число, либо ноль,
// функция ничего не должна выводить.
function numberPositive(number) {
    if (typeof number !== 'number') {
        console.log(typeof number);
        return;
    } else {
        console.log(`${typeof number} ${number}`);
    }

    if (number > 0) {
        console.log('+++');
    } else if (number < 0) {
        console.log('---');
    }
}

numberPositive('6');
numberPositive(0);
console.log('///');
numberPositive(5);
numberPositive(-5);

// Тайминг: 20 минут.

