const express = require('express');
const fs = require('fs');
const path = require('path');

const app = express();
const port = 3000;

const nameFile = 'users.json';
const pathFile = path.join(__dirname, nameFile);

app.use(express.json());

app.get('/users', (req, res) => { });
app.get('/', (req, res) => { });
app.post('/', (req, res) => { });
app.put('/', (req, res) => { });
app.delete('/', (req, res) => { });