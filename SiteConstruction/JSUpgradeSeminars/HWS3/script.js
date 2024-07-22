const divReviewBoxEl = document.querySelector('div.review-box');

const inputProductNameEl = document.querySelector('input.product-name');
const inputProductReviewEl = document.querySelector('input.product-review');
const addReviewButtonEl = document.querySelector('button.add-review');

console.log(inputProductNameEl);
console.log(inputProductReviewEl);
console.log(addReviewButtonEl);

const lsReviewListKey = 'reviews';
function getReviewsList() {
    const reviews = localStorage.getItem(lsReviewListKey);
    if (!reviews) {
        return [];
    }
    return JSON.parse(reviews);
}

function checkInputFields(reviewName, reviewText) {
    const alertMessageEl = document.createElement('p');
    if (!reviewName) {
        alertMessageEl.innerHTML = "Поле названия продукта не может быть пустым!"
        inputProductNameEl.insertAdjacentElement("afterEnd", alertMessageEl);
        return false;
    } else if (!reviewText) {
        alertMessageEl.innerHTML = "Поле отзыва не может быть пустым!"
        inputProductReviewEl.insertAdjacentElement("afterEnd", alertMessageEl);
        return false;
    }

    if (alertMessageEl.innerHTML === "") {
        console.log('bingo');
        const alertMessageEls = document.querySelectorAll('p');
        console.log(alertMessageEls);
        alertMessageEls.forEach(element => {
            element.remove();
        });
    }
    return true;
}

addReviewButtonEl.addEventListener('click', () => {
    let reviews = getReviewsList();
    const reviewName = inputProductNameEl.value.trim();
    const reviewText = inputProductReviewEl.value.trim();
    const checkInputFieldsConst = checkInputFields(reviewName, reviewText);
    // if (condition) {

    // }
});