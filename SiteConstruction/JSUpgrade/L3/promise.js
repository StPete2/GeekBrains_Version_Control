let promise = new Promise(function (resolve, reject) {
    // функция-исполнитель
    // если мы передаем функцию в качестве аргумента это и есть коллбэк
    // состояние: pending (ожидание), fulfilled (выполнено) или rejected (отклонено);
});

// promise.then(onfulfilled, onrejected);

let generateRandomNumber = () => {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            const randomNumber = Math.floor(Math.random() * 10) + 1;
            if (randomNumber) {
                resolve(randomNumber);
            } else {
                reject("Ошибка генерации случайного числа");
            }
        }, 1000);
    });
};

generateRandomNumber()
    .then((number) => {
        console.log("Random number is: ", number);
    })
    .catch((error) => {
        console.log("Error: ", error);
    });

