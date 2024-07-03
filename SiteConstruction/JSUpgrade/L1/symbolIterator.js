let range = {
    from: 1,
    to: 17,
};

range[Symbol.iterator] = function () {
    return {
        current: this.from,
        last: this.to,
        next() {
            return this.current <= this.last
                ? { done: false, value: this.current++ }
                : { done: true };
        },
    };
};

for (let number of range) {
    console.log(number);
}
