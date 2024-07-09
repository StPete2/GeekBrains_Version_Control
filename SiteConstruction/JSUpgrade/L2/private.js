class Automobile {
    #horsePowers = 0;
    // set horsePowers(value) {
    //     this.#horsePowers = value;
    // }
    get horsePowers() {
        return this.#horsePowers;
    }
    constructor(power) {
        this.#horsePowers = power;
    }
}

let auto = new Automobile(100);
auto.horsePowers = 10;
console.log(auto.horsePowers);
auto.horsePowers = 20;
console.log(auto.horsePowers);
// auto.#horsePowers = 50; - так не работает.

class Automobile2 {
    _horsePowers = 0;
    // set horsePowers(value) {
    //     this._horsePowers = value;
    // }
    get horsePowers() {
        return this._horsePowers;
    }
    constructor(power) {
        this._horsePowers = power;
    }
}

let auto2 = new Automobile2(50);

console.log(auto2.horsePowers);
auto2.horsePowers = 60;
console.log(auto2.horsePowers);