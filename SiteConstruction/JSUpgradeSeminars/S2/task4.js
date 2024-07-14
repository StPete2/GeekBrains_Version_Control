/*
Задание 4:
Пользователи вашего сайта могут добавлять элементы в список. Но есть условие: 
введенное значение должно содержать от 3 до 10 символов.

Создайте HTML-структуру

Необходимо обрабатывать событие добавления элемента в список. Функция, 
обрабатывающая событие, должна выбрасывать исключение, если длина введенного 
значения не соответствует требованиям.
Если исключение было выброшено, необходимо добавить сообщение об ошибке в div.
Не важно, была ошибка или нет, после того как мы совершим попытку добавления 
данных, необходимо вывести в консоль "Попытка добавления элемента завершена."
*/

const inputEl = document.querySelector("input.user-input");
const buttonEl = document.querySelector("button.add-button");
const ulListEl = document.querySelector("ul.item-list");
const divErrorMessageEl = document.querySelector("div.error-message");

// buttonEl.addEventListener("click", () => {
//     const userInput = inputEl.value;
//     if (userInput.length < 3 || userInput.length > 10) {
//         divErrorMessageEl.textContent = 'Длина текста не соответствует требованиям';
//     } else {
//         const liEl = document.createElement('li');
//         liEl.textContent = userInput;
//         ulListEl.appendChild(liEl);
//         inputEl.value = "";
//         divErrorMessageEl.textContent = "";
//     }
//     console.log("Попытка добавления элемента завершена");
// });

buttonEl.addEventListener("click", () => {
    try {
        const userInput = inputEl.value;
        if (userInput.length < 3 || userInput.length > 10) {
            throw new Error("Длина текста не соответствует требованиям");
        }
        const liEl = document.createElement("li");
        liEl.textContent = userInput;
        ulListEl.appendChild(liEl);
        inputEl.value = "";
        divErrorMessageEl.textContent = "";
    } catch (error) {
        // console.error(error);
        divErrorMessageEl.textContent = error.message;
    } finally {
        console.log("Попытка добавления элемента завершена");
    }
});
