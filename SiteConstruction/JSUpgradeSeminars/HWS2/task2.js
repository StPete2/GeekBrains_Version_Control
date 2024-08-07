// Задание 2
// Вы разрабатываете систему отзывов для вашего веб-сайта. Пользователи могут оставлять отзывы, но чтобы исключить слишком короткие или слишком длинные сообщения, вы решаете установить некоторые ограничения.

// Создайте HTML-структуру с текстовым полем для ввода отзыва, кнопкой для отправки и контейнером, где будут отображаться отзывы.

// Напишите функцию, которая будет добавлять отзыв в контейнер с отзывами. Однако если длина введенного отзыва менее 50 или более 500 символов, функция должна генерировать исключение.

// При добавлении отзыва, он должен отображаться на странице под предыдущими отзывами, а не заменять их.

// Вы можете использовать этот массив initialData для начальной загрузки данных при запуске вашего приложения.

// const fs = require('fs');
// const path = require('path');
// const fileName = "data.json";
// const fullFileName = path.join(__dirname, fileName);

// const savedData = JSON.parse(fs.readFileSync(fullFileName));
// console.log(savedData);

const divContainerReviewsEl = document.querySelector('div.container-reviews');
const reviewsData = [
    {
        product: "Apple iPhone 13",
        reviews: [
            {
                id: "1",
                text: "Отличный телефон! Батарея держится долго.",
            },
            {
                id: "2",
                text: "Камера супер, фото выглядят просто потрясающе.",
            },
        ],
    },
    {
        product: "Samsung Galaxy Z Fold 3",
        reviews: [
            {
                id: "3",
                text: "Интересный дизайн, но дорогой.",
            },
        ],
    },
    {
        product: "Sony PlayStation 5",
        reviews: [
            {
                id: "4",
                text: "Люблю играть на PS5, графика на высоте.",
            },
        ],
    },
];
// console.log(reviewsData);

reviewsData.forEach((elem) => {
    const templateEl = document.querySelector('#review-template');
    const reviewsBox = document.querySelector('div.reviews-box');
    // console.log(templateEl.content);
    // console.log(elem.reviews);
    const cloneEl = templateEl.content.cloneNode(true);
    cloneEl.querySelector('h3.device-name').innerHTML = elem.product;
    if (elem.reviews.length > 1) {
        elem.reviews.forEach((element) => {
            cloneEl.querySelector('p.review-number').innerHTML = element.id;
            cloneEl.querySelector('p.review-text').innerHTML = element.text;
        });
    }
    divContainerReviewsEl.appendChild(cloneEl);
});