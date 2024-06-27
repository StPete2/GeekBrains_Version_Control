const express = require("express");
const fs = require("fs");
const path = require("path");

const app = express();
const port = 3000;
let uniqueID = 3;

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
        res.status(404).send({
            user: null,
            error: "User not found",
            status: "Test status",
        });
    }
});
app.post("/users/", (req, res) => {
    const users = JSON.parse(fs.readFileSync(pathFile));
    const user = {
        id: uniqueID++,
        name: req.body.name,
        familyName: req.body.familyName,
        age: req.body.age,
    };
    users.push(user);
    fs.writeFileSync(pathFile, JSON.stringify(users, null, 2));
    res.send({ user });
});

app.put("/users/:id", (req, res) => {
    const users = JSON.parse(fs.readFileSync(pathFile));
    const user = users.find((user) => user.id === Number(req.params.id));
    if (user) {
        user.name = req.body.name;
        user.familyName = req.body.familyName;
        user.age = req.body.age;
        fs.writeFileSync(pathFile, JSON.stringify(users, null, 2));

        res.send({ user });
    } else {
        res.status(404).send({
            user: null,
            error: "User not found",
            status: "Test status",
        });
    }
});
app.delete("/users/:id", (req, res) => {
    const users = JSON.parse(fs.readFileSync(pathFile));
    const userIndex = users.findIndex(
        (user) => user.id === Number(req.params.id)
    );
    // console.log(userIndex);
    if (userIndex > -1) {
        users.splice(userIndex, 1);
        fs.writeFileSync(pathFile, JSON.stringify(users, null, 2));
        res.send({ status: "ok" });
    } else {
        res.status(404).send({
            user: null,
            error: "User not found",
            status: "Test status",
        });
    }
});

app.listen(port);
