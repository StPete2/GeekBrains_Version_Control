class CustomError extends Error {
    constructor(message) {
        super(message);
        this.name = 'CustomError';
    }
}

function validateNumber(value) {
    if (typeof value !== 'number') {
        throw new CustomError('Значение должно быть числом');
    }
    console.log('Validation successful');
}

try {
    validateNumber(Infinity);
} catch (error) {
    if (error instanceof CustomError) {
        console.error('Ошибка: ', error.message);
        console.log('Type of error: ', error.name);
    } else {
        console.error('Default error message: ', error);
    }
}

console.log(typeof null);
console.log(typeof undefined);
console.log(typeof true);
console.log(typeof Symbol());
console.log(typeof '');
console.log(typeof Infinity);
