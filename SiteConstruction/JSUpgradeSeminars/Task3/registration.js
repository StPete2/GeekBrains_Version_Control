const buttonEl = document.querySelector("button.register");
const inputLoginEl = document.querySelector("#login");
const passwordEl = document.querySelector("#password");
const lsUsersKey = "users";

buttonEl.addEventListener("click", () => {
    const login = inputLoginEl.value;
    const password = passwordEl.value;
    if (localStorage.getItem(lsUsersKey)) {
        const users = JSON.parse(localStorage.getItem(lsUsersKey));
        if (users.some((user) => user.login === login)) {
            console.log("User already exists!");
            return;
        }
        users.push({ login, password });
        localStorage.setItem(lsUsersKey, JSON.stringify(users));
    } else {
        const users = [{ login, password }];
        localStorage.setItem(lsUsersKey, JSON.stringify(users));
    }
    location.href = "login.html";
});
