// 1. Создайте файл writePerson.js
// 2. Напишите код, который создаст файл person.json в директории
// запускаемого скрипта и запишет в файл следующий объект:
// {
//     "name": "Ivan",
//     "surname": "Ivanov",
//     "age": 30,
//     "city": "Moscow"
// }
// 💡 Подсказки:
// - Для преобразования объекта в текст используйте функцию JSON.stringify()
// - Для определения пути к файлу, используйте модуль path и его метод .join(),
// а также глобальное свойство __dirname
// - Используйте синхронный метод записи в файл

const fs = require("fs");
const path = require("path");
const filePath = path.join(__dirname, "person.json");

const obj = {
    name: "Ivan",
    surname: "Ivanov",
    age: 30,
    city: "Moscow",
};

fs.writeFileSync(filePath, JSON.stringify(obj, null, 2));

