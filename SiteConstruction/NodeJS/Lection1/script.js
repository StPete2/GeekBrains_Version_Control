const http = require("http"); //название встроенного модуля. Возвращает объект модуля и мы его записываем в константу. Объект.

const server = http.createServer((req, res) => {
    // Создаем http сервер. В первый аргумент добавляем call back, который вернется, когда придет http запрос.
    console.log("Запрос получен");

    // res.writeHead(200, {
    //     'Content-Type': 'text/html; charset=UTF-8',
    // });
    // res.end('<h1>Добро пожаловать!</h1>');

    if (req.url === "/") {
        res.writeHead(200, {
            "Content-Type": "text/html; charset=UTF-8",
        });
        res.end("<h1>Добро пожаловать!</h1>");
    } else if (req.url === "/about") {
        res.writeHead(200, {
            "Content-Type": "text/html; charset=UTF-8",
        });
        res.end("<h1>About</h1>");
    }
});

const port = 3000; //

server.listen(port, () => {
    // у объекта Сервер вызываем функцию listen.
    console.log(`Сервер запущен на порту ${port}`);
});
