/*
Задание 2: 
Создайте обычный объект library. Необходимо реализовать Symbol.iterator, у 
которого каждая итерация будет возвращать следующую книгу из библиотеки.
Продемонстрируйте работу Symbol.iterator у нашего объекта.
*/
// Список книг:
const books = [
    { title: "1984", author: "George Orwell" },
    { title: "Brave New World", author: "Aldous Huxley" },
    { title: "Fahrenheit 451", author: "Ray Bradbury" },
];

const library = {
    // books: books,
    books,
    // [Symbol.iterator]: function* () {
    //     for (const book of this.books) {
    //         yield book;
    //     }
    // }

    *[Symbol.iterator]() {
        // функция-генератор, которая возвращает не одно значение
        for (const book of this.books) {
            yield book; // продолжает работу после вызова первой книги! в отличие от return
        }
    },
};

// for (const book of library) {
//     console.log(book);
// }

const iterator = library[Symbol.iterator]();
console.log(iterator);

// console.log(iterator.next());
// console.log(iterator.next());
// console.log(iterator.next());
// console.log(iterator.next());
// console.log(iterator.next());

const library2 = {
    books: books,
    [Symbol.iterator]() {
        let index = 0;
        return {
            // next:() => { ещё один вариант - через стрелочную функция. Стрелочная функция всегда запоминает окружение и будет работать через this.books.lenght
            next() {
                if (index < books.length) {
                    return {
                        value: books[index++],
                        done: false,
                    };
                }
                return {
                    value: undefined,
                    done: true,
                };
            },
        };
    },
};

for (const book of library2) {
    console.log(book);
}