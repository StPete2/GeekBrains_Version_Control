const express = require("express");
const fs = require("fs");
const path = require("path");

const app = express();
const port = 3000;

const nameFile = "users.json";
const pathFile = path.join(__dirname, nameFile);

app.use(express.json());

app.get("/users", (req, res) => {
    const users = JSON.parse(fs.readFileSync(pathFile));
    res.send({ users });
});

app.get("/users/:id", (req, res) => {
    // все, что будет после слэша (users/) будет считаться параметром id и внутри экспресса появится в объекте params в свойстве id
    const users = JSON.parse(fs.readFileSync(pathFile));
    const user = users.find((user) => user.id === Number(req.params.id));
    if (user) {
        res.send({ user });
    } else {
        res
            .status(404)
            .send({
                user: null,
                error: "User not found",
                status: "Test status"
            });
    }
});
// app.post('/', (req, res) => { });
// app.put('/', (req, res) => { });
// app.delete('/', (req, res) => { });

app.listen(port);
