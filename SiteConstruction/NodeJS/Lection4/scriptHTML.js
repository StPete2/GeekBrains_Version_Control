const express = require("express");
const app = express();

const articles = [
    { title: "Article1", description: "Description1" },
    { title: "Article2", description: "Description2" },
    { title: "Article3", description: "Description3" },
];

app.get("/", (req, res) => {
    let html = "<h1>Articles' List </h1>";

    for (const articleData of articles) {
        html += `<h2>${articleData.title}</h2>`;
        html += `<p>${articleData.description}</p>`;
    }

    res.send(html);
});

const port = 3200;
app.listen(port);
