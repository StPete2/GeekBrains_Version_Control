// console.log(window);
// console.log(window.window);
// console.log(self);
// console.log(frames);
// console.log(globalThis);

// const newWindow = window.open('https://ya.ru', '_blank'); // открывает новое окно браузера
// newWindow.close();
// window.resizeTo(800, 600);
// window.location.href = 'https://ya.ru';

// console.log(window.location);

// const windowWidth = window.innerWidth;
// console.log(windowWidth);

// console.log(global);

// const isWindowOpen = window.window.open('https://ya.ru') !== null;
// console.log(isWindowOpen);

const a = window.Symbol.for("key");
console.log(a);
console.log(window.Symbol.keyFor(a));

function increment(val) {
    return val + 1;
}

console.log(window.increment(5));
// console.log(window.alert() === alert());
