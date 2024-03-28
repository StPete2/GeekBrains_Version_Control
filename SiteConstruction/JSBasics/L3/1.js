const f = (param = 5) => {
    console.log(param * param);
}

f();
f(10);
f(2 + 2);

function helloName(name) {
    console.log(name);
}

helloName('Aleksey');

let count = 5;

function countIncrementor() {
    return count++;
}

countIncrementor();
console.log(count);

let age = Number(prompt('Сколько Вам лет?'));

function upAge() {
    return age + 5;
}

console.log(`Через 5 лет Вам будет ${upAge()}`);

const lvlUpAge = () => {
    return age + 5;
}

const lvlUpAge2 = () => age + 5;

console.log(`Через 5 лет Вам будет ${lvlUpAge()}`);

const sum = (param1, param2) => {
    return param1 + param2;
}

console.log(sum(2, 3));

function buy() {
    alert('Поздравляем!');
    alert('Вы купили наш товар!');
}