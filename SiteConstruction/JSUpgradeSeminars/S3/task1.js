/*
Задание 1: 
Вы разрабатываете прототип веб-приложения для чтения новостей. Статьи "хранятся" 
во внутреннем массиве (имитируя базу данных). Когда пользователь нажимает на 
кнопку "Загрузить новости", ваш код должен имитировать задержку, словно 
происходит реальная загрузка данных из внешнего источника, а после этой 
задержки — отображать новости на странице.

1. Создайте базовую HTML-структуру с кнопкой для загрузки новостей и контейнером 
для их отображения.
2. Реализуйте функцию fetchNews(), возвращающую промис. Эта функция должна 
имитировать задержку в 2 секунды перед успешным возвращением данных из 
"виртуальной" базы данных. Для добавления интереса: с вероятностью 10% она 
должна возвращать ошибку вместо данных.
3. При нажатии на кнопку "Загрузить новости" вызывайте функцию fetchNews(), 
обрабатывая успешное выполнение и ошибки с использованием then() и catch().
При успешной загрузке отобразите статьи на странице. При ошибке покажите 
сообщение об ошибке.
4. Добавьте функционал, который отключает кнопку загрузки на время "загрузки" 
новостей и активирует её снова после завершения операции (будь то успешная 
загрузка или ошибка).
*/

const newsContainer = document.querySelector("div.content");
const buttonEl = document.querySelector("button.load");
const newsArray = [
    {
        title: "title1",
        text: "text1",
    },
    {
        title: "title2",
        text: "text2",
    },
    {
        title: "title3",
        text: "text3",
    },
];
let i = 0;

const fetchNews = () => {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            if (Math.random() < 0.1) {
                reject(new Error("Ошибка при загрузке новостей"));
            }
            resolve(newsArray[i++]);
        }, 1000);
    });
};

function addNews(news) {
    const newsParagraph = document.createElement("div");
    const newsTitle = document.createElement("h3");
    const newsText = document.createElement("p");
    newsTitle.innerHTML = news.title;
    newsText.innerHTML = news.text;
    newsParagraph.append(newsTitle);
    newsParagraph.append(newsText);
    newsContainer.append(newsParagraph);
}
// newsContainer.innerHTML = `<h1>${news.title}</h1>`; такая запись тоже будет работать
// newsContainer.insertAdjacentHTML("beforeend", `<h1>${news.title}</h1`);

buttonEl.addEventListener("click", () => {
    buttonEl.disabled = true; // свойство у кнопки
    fetchNews()
        .then((news) => {
            addNews(news);
        })
        .catch((error) => {
            console.error(error.message);
        })
        .finally(() => {
            buttonEl.disabled = false;
        });
});
