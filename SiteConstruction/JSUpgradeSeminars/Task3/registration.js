import { getUsers, registerUser } from "./storage.js";

const buttonEl = document.querySelector("button.register");
const inputLoginEl = document.querySelector("#login");
const passwordEl = document.querySelector("#password");

buttonEl.addEventListener("click", () => {
    const login = inputLoginEl.value;
    const password = passwordEl.value;
    const users = getUsers();

    if (users.some((user) => user.login === login)) {
        console.log("User already exists!");
        return;
    }
    registerUser(login, password);
    location.href = "login.html";
});
