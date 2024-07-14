// пример не работает!

// const fs = require("fs");
// const path = require("path");

let checkIfFileExists = (file) => {
};

let checkFileExists = (file) => {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            const fileExists = checkIfFileExists(file);
            // console.log(fileExists);
            if (fileExists) {
                resolve("File found and exists");
            } else {
                reject("File not found");
            }
        }, 2000);
    });
};

// const fullFilePath = path.join(__dirname, "fetch.js");
// console.log(fullFilePath);
checkFileExists("fetch.js")
    .then((message) => {
        console.log(message);
    })
    .catch((error) => {
        console.error("Error: ", error);
    });
