function divideNumbers(a, b) {
    try {
        const result = a / b;
        if (isNaN(result)) {
            throw new Error("Результат не является числом");
        }
        console.log(`Результат деления: ${result}`);
    } catch (error) {
        console.error("Ошибка деления:", error);
    } finally {
        console.log("Операция деления завершена");
    }
}

// divideNumbers(10, 2);
// divideNumbers(1, 0);
divideNumbers(1, 'a');
console.log("new console log");
