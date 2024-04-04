const product = {
    name: 'Стол',
    price: 2000,
    count: 2,
    buy: function () {
        console.log('Вы купили данный товар');
    }
}

product.buy();

for (const key in product) {
    console.log(key + ': ' + product[key]);
}

const array = [1, 3, 5, 10, 15];
const arrayMapped = array.map(item => item * 2);
console.log(arrayMapped);

const arrayFiltered = array.filter(item => item >= 10);
console.log(arrayFiltered);

const arraySomed = array.some(item => item >= 15);
console.log(arraySomed);

const arrayReduced = array.reduce((a, b) => a + b);
console.log(arrayReduced);