// Задание 1:

// 1. Создайте объект с ключами от 1 до 7, в качестве значений содержащий имена 
// дней недели. Выведите на экран “Вторник”.
const week = {
    1: 'Понедельник',
    2: 'Вторник',
    // two: 'Вторник',
    3: 'Среда',
    4: 'Четверг',
    5: 'Пятница',
    6: 'Суббота',
    7: 'Воскресенье'
};
// console.log(week.two);
console.log(week[2]);


// 2. Создайте объект user с ключами 'name', 'surname', 'age'. Выведите в консоль
// фамилию, имя и возраст одной строкой.
const user = {
    name: 'Ivan',
    surname: 'Gorchakov',
    age: '30'
};
console.log(user);
console.log(user.name, user.surname, user.age);

// 3. Добавьте в объект user свойство отчество, которое пользователь должен 
// ввести с клавиатуры.
// user.patronymic = prompt('Введите отчество');
user.patronymic = 'Otchestvo';
console.log(user.name, user.patronymic, user.surname, user.age);
// 4. Удалите свойство surname.

delete user.surname;
console.log(user);
// Тайминг: 20 минут.

// Задание 2:

// 1. Создайте два массива: первый с названиями дней недели, а второй - с их 
// порядковыми номерами:
// `['пн', 'вт', 'ср', 'чт', 'пт', 'сб', 'вс']`
// `[1, 2, 3, 4, 5, 6, 7]`
const weekDays = ['пн', 'вт', 'ср', 'чт', 'пт', 'сб', 'вс'];
const weekNumbers = [1, 2, 3, 4, 5, 6, 7];

// 2. С помощью цикла создайте объект, ключами которого будут названия дней, 
// а значениями - их номера.
const weekDaysNumbers = {};

for (let i = 0; i < weekDays.length; i++) {
    weekDaysNumbers[weekDays[i]] = weekNumbers[i];
}
console.log(weekDaysNumbers);

// 3. Создайте объект: `{x: 1, y: 2, z: 3}`. Переберите этот объект циклом и 
// возведите каждый элемент этого объекта в квадрат.
const xyz = {
    x: 1,
    y: 2,
    z: 3
};
for (const key in xyz) {
    xyz[key] = xyz[key] ** 2;
}

console.log(xyz);
// Тайминг: 25 минут.

