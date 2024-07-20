import { getAuthLogin, logoutUser } from "./storage.js";

const authUser = getAuthLogin();
const helloMessageEl = document.querySelector('p.hello-message');
const buttonEl = document.querySelector('button.logout');

if (!authUser) {
    console.log('Нет доступа');
    location.href = "login.html";
}

helloMessageEl.textContent = `Hello, ${authUser}!`;

buttonEl.addEventListener('click', () => {
    logoutUser();
    location.href = "login.html";
});