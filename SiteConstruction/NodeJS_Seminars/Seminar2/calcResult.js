const NP = require("number-precision");
// const { plus, times: mult } = require("number-precision");

function calculateResultSum(purchases, discount) {
    let total = purchases.reduce((acc, purchase) => NP.plus(acc, purchase), 0);
    // let total2 = purchases.reduce((acc, purchase) => plus(acc, purchase), 0);

    total = NP.times(total, discount);
    // total2 = times(total, discount);
    // total2 = mult(total, discount);
    return total;
}

module.exports = { calculateResultSum };

// module.exports.calculateResultSum = calculateResultSum;