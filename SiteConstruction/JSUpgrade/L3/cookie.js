console.log(typeof document.cookie);
document.cookie = "TEST=1";
console.log(document.cookie);

let setCookie = (name, value, days) => {
    let expirationDate = new Date();
    expirationDate.setDate(expirationDate.getDate() + days);
    let cookieValue =
        encodeURIComponent(value) + "; expires=" + expirationDate.toUTCString();
    document.cookie = name + "=" + cookieValue;
};

setCookie("username", "Aleksey", 7);
setCookie("username2", "Tom_Soyer", 7);
console.log(document.cookie);

let getCookie = (name) => {
    let cookies = document.cookie.split(";");
    for (let cookie of cookies) {
        let [cookieName, cookieValue] = cookie.trim().split("="); // деструктуризация, или распаковка
        if (cookieName === name) {
            return decodeURIComponent(cookieValue);
        }
    }
    return null;
};

let cookie = getCookie("username");
console.log(cookie);
console.log(getCookie("TEST"));

let deleteCookie = (name) => {
    document.cookie =
        name + "=; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;";
};

deleteCookie("username2");
console.log(getCookie("username2"));
console.log(document.cookie);
