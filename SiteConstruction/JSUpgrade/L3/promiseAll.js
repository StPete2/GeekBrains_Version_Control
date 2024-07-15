Promise.all([
    new Promise((resolve, reject) => setTimeout(() => resolve(1), 1000)),
    new Promise((resolve, reject) => setTimeout(() => resolve(2), 1000)),
    new Promise((resolve, reject) => setTimeout(() => resolve(3), 1000)),
])
    .then(console.log)
    .catch(console.log);

new Promise((resolve, reject) => {
    throw new Error("error thrown");
})
    .catch((error) => {
        console.log(`Ошибка ${error} обработана. Продолжаем работу`);
    })
    .then(() => console.log("Управление перешло в следующий then"));

Promise.allSettled([
    new Promise((resolve, reject) => setTimeout(() => resolve(1), 1000)),
    new Promise((resolve, reject) =>
        setTimeout(() => reject(new Error("Ошибка!")), 1000)
    ),
    new Promise((resolve, reject) => setTimeout(() => resolve(3), 1000)),
])
    .then(console.log)
    .catch(console.log);
