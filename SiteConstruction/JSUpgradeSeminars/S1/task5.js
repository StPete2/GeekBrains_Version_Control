"use strict";

class Book {
    constructor(title, author) {
        this.title = title;
        this.author = author;
        this.read = false;
    }

    readed() {
        this.read = true;
        return this; // цепочка выводов
    }
}

const book1 = new Book("Harry Porter", "J.K. Rowling");
book1.readed().readed();

console.log(book1);

const s = new Set();
s.add(1).add(2);


