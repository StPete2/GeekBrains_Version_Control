localStorage.setItem("Username", "John");
let nameLS = localStorage.getItem("Username");
console.log(nameLS);

// localStorage.removeItem("Username");
console.log(localStorage);

if (localStorage.getItem("counter")) {
    let counter = parseInt(localStorage.getItem("counter")) + 1;
    localStorage.setItem("counter", counter.toString());
} else {
    localStorage.setItem("counter", "1");
}

let counter3 = localStorage.getItem("counter3")
    ? parseInt(localStorage.getItem("counter3"))
    : 0;

const updateCounter = () => {
    counter3++;
    localStorage.setItem("counter3", counter3.toString());
};

document.querySelector("button.counter").textContent = counter3;
document.querySelector("button.increment").addEventListener("click", () => {
    updateCounter();
    document.querySelector(".counter").textContent = counter3;
});
