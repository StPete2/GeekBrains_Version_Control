const express = require('express');
const path = require('path');

const app = express();

// app.use(express.static('static'));

app.use((req, res, next) => {
    console.log('Поступил запрос', req.method, req.url);
    next();
});

app.get('/', (req, res) => {
    // res.send('<h1>Добро пожаловать!</h1>');
    res.sendFile(path.join(__dirname, '/index.html'));
    // res.sendFile('static/index.html');
});

app.get('/about.html', (req, res) => {
    res.send('<h2>Страница обо мне</h2>');
});

const port = 3000;
app.listen(port, () => {
    console.log(`Сервер запущен на порту ${port}`);
});