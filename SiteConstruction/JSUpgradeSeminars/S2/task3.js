/*
Задание 3: 
Вы создаете интерфейс, где пользователь вводит число. Ваша задача — проверить, 
является ли введенное значение числом или нет, и дать соответствующий ответ.

Необходимо обрабатывать событие проверки числа пользователем, проверяющая 
функция должна использовать try и catch для проверки вводимого значения.
*/

const inputEl = document.querySelector("input.number-input");
const buttonEl = document.querySelector("button.check-button");
const messageEl = document.querySelector("div.message");

console.log(inputEl);
console.log(buttonEl);
console.log(messageEl);

buttonEl.addEventListener("click", () => {
    if (Number.isFinite(+inputEl.value) && inputEl.value !== "") { // входные данные от input всегда string
        // +inputEl при пустой строке превращет её в 0
        messageEl.textContent = "Number";
    } else {
        messageEl.textContent = "Not a number";
    }
});

buttonEl.addEventListener('click', () => {
    try {
        if (!Number.isFinite(+inputEl.value) || inputEl.value === "") {
            throw new Error("Not a number");
        }
        messageEl.textContent = "Number";
    } catch (error) {
        messageEl.textContent = error.message;
    }
});

