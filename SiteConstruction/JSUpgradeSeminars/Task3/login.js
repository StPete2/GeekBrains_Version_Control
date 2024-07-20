import { loginUser } from './storage.js';

const buttonEl = document.querySelector("button.login-btn");
const inputLoginEl = document.querySelector("#login");
const passwordEl = document.querySelector("#password");

buttonEl.addEventListener("click", () => {
    const login = inputLoginEl.value;
    const password = passwordEl.value;
    try {
        loginUser(login, password);
        location.href = "hello.html";
    } catch (error) {
        console.log(error.message);
    }
});