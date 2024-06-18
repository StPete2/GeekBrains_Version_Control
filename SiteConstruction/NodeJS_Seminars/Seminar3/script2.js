// 1. Создайте файл changePerson.js рядом с файлом writePerson.js
// 2. Напишите в нем код, который
// - прочитает файл person.json,
// - уменьшит возраст на 10
// - изменит город на “Ekaterinburg”
// - перезапишет исходный файл person.json

// 💡 Подсказки:
// - Для преобразования текста в объект, необходимо использовать
// функцию JSON.parse()
// - Также не забывайте, что путь к файлу необходимо формировать
// с помощью path.join() и __dirname
// - Используйте синхронные методы чтения и записи

const path = require('path');
const fs = require('fs');
const filePath = path.join(__dirname, "person.json");
const obj = JSON.parse(fs.readFileSync(filePath));
// console.log(obj);

obj.age -= 10;
obj.city = "Ekaterinburg";

fs.writeFileSync(filePath, JSON.stringify(obj, null, 2));

