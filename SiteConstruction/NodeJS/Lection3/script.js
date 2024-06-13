const fs = require('fs');
fs.readFile(__filename, 'utf-8', (err, data) => {
    if (err) {
        console.error(err);
    } else {
        console.log(data);
    }
});

fs.writeFile('./test.txt', 'console.log("hello!")', (err) => {
    if (err) {
        console.error(err);
    }
    console.log('The file was saved');
});

fs.appendFile('./test.txt', '\nconsole.log("Hello 2nd line")', (err) => {
    if (err) {
        console.error(err);
    }
    console.log('The file was saved!');
});