// недоделано!
const express = require('express');
const { engine } = require('express-handlebars');

const app = express();

app.engine('handlebars', engine());
app.set('view engine', 'handlebars');
app.set('views', './views'); // 16 минута лекции (15 и далее до 17)

const articles = [
    { title: "Article 1", description: "Article1 desc" },
    { title: "Article 2", description: "Article2 desc" },
    { title: "Article 3", description: "Article3 desc" },
];

app.get('/', (req, res) => {
    res.render('home', { title: 'Home', articles });
});

app.listen(3400);