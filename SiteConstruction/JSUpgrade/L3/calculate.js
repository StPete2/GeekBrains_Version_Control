let calculateSum = (a, b) => {
    return new Promise((resolve, reject) => {
        const sum = a + b;
        resolve(sum);
    });
};

calculateSum(3, 7).then((result) => {
    console.log("sum is:", result);
});
