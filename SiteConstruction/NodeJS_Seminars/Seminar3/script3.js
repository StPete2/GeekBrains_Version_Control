// 1. Инициализируйте проект NPM.
// 2. Установите библиотеку express.
// 3. Создайте файл index.js.
// 4. В файле напишите код который реализует два обработчика по URL “/” и URL
// “/about”.
// 5. В каждом обработчике верните HTML код, в котором есть заголовок и ссылка
// на соседнюю страницу.

const express = require("express");
const app = express();
app.get("/", function (req, res) {
    res.send(`<h1>Main page</h1>
        <a href="/about"> to about page </a>`);
});

app.get("/about", function (req, res) {
    res.send(`<h1>About page</h1>
        <a href="/"> to main page </a>`);
});

const port = 3000;

app.listen(port);
