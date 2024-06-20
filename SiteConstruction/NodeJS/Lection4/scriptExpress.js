const fs = require("fs");
const path = require("path");

const express = require("express");
const handlebars = require("handlebars");
const app = express();

const articles = [
    { title: "Article 1", description: "Article1 desc" },
    { title: "Aritcle 2", description: "Article2 desc" },
    { title: "Article 3", description: "Article3 desc" },
];

app.get('/', (req, res) => {
    const pathToTemplate = path.join(
        __dirname,
        './home.handlebars'
    );

    fs.readFile(pathToTemplate, 'utf-8', (err, data) => {
        if (err) {
            res.status(500);
            res.send(err.message);
        } else {
            const template = handlebars.compile(data);
            res.send(template({ articles }));
        }
    });
});

const port = 3300;
app.listen(port);