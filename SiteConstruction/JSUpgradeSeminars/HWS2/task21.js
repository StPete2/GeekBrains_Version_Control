// Задание 2
// Вы разрабатываете систему отзывов для вашего веб-сайта. Пользователи могут оставлять отзывы, но чтобы исключить слишком короткие или слишком длинные сообщения, вы решаете установить некоторые ограничения.

// Создайте HTML-структуру с текстовым полем для ввода отзыва, кнопкой для отправки и контейнером, где будут отображаться отзывы.

// Напишите функцию, которая будет добавлять отзыв в контейнер с отзывами. Однако если длина введенного отзыва менее 50 или более 500 символов, функция должна генерировать исключение.

// При добавлении отзыва, он должен отображаться на странице под предыдущими отзывами, а не заменять их.

// Вы можете использовать этот массив initialData для начальной загрузки данных при запуске вашего приложения.

const divContainerReviewsEl = document.querySelector("div.container-reviews");
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

const deviceNameEl = document.querySelector("h3.device-name");
const reviewsBoxEl = document.querySelector("div.reviews-box");
const reviewEl = document.querySelector("div.review");
const reviewNumberEl = document.querySelector("p.review-number");
const reviewTextEl = document.querySelector("p.review-text");
const divDeviceEl = document.querySelector("div.device");
// console.log(deviceNameEl);
// console.log(reviewsBoxEl);
// console.log(reviewEl);
// console.log(reviewNumberEl);
// console.log(reviewTextEl);

reviewsData.forEach((element) => {
    const deviceNameElInside = document.createElement("h3");
    deviceNameElInside.innerHTML = element.product;
    console.log(element);
    const divDeviceElInside = document.createElement("div");
    divDeviceElInside.appendChild(deviceNameElInside);
    if (element.reviews.length > 1) {
        element.reviews.forEach((reviewsElem) => {
            const reviewNumberElInside = document.createElement("p");
            reviewNumberElInside.innerHTML = reviewsElem.id;
            divDeviceElInside.appendChild(reviewNumberElInside);
            const reviewTextElInside = document.createElement("p");
            reviewTextElInside.innerHTML = reviewsElem.text;
            divDeviceElInside.appendChild(reviewTextElInside);
        });
    } else {
        const reviewNumberElInside = document.createElement("p");
        reviewNumberElInside.innerHTML = element.reviews[0].id;
        divDeviceElInside.appendChild(reviewNumberElInside);
        const reviewTextElInside = document.createElement("p");
        reviewTextElInside.innerHTML = element.reviews[0].text;
        divDeviceElInside.appendChild(reviewTextElInside);
    }
    divContainerReviewsEl.appendChild(divDeviceElInside);
});

// поймать данные, которые вводит пользователь

// записать в свой device отзыв.