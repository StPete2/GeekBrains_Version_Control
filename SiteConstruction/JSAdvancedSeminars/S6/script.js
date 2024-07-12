const dataJs = JSON.parse(dataProductsSem);
console.log(dataJs);

const cartItems = document.querySelector('div.cart-items');
const cartItemsBox = cartItems.querySelector('div.cart-items__box');

dataJs.forEach(element => {
    const templateEl = document.querySelector('#cart-template');
    // console.log(templateEl.content);
    const cloneEl = templateEl.content.cloneNode(true);

    cloneEl.querySelector('img.cart-item__img').src = element.imgSrc;
    cloneEl.querySelector('h2.cart-item__heading').innerHTML = element.h2FirstLine;
    cloneEl.querySelector('h2.cart-item__heading_second_line').innerHTML = element.h2SecondLine;
    cloneEl.querySelector('span.cart-item__attribute').innerHTML = element.price;
    cloneEl.querySelector('span.cart-item__attribute-meaning').innerHTML = element.color;
    cloneEl.querySelector('span.cart-item__attribute-meaning-size').innerHTML = element.size;
    cloneEl.querySelector('#cart-item__quantity').value = element.inputValue;
    cartItemsBox.appendChild(cloneEl);
});