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

