function sayHello() {
    console.log("hello");
}

console.log(sayHello.name);
console.log(window.name);

class Rectangle {
    constructor(width, height) {
        this.width = width;
        this.height = height;
    }
}

const rect = new Rectangle(10, 5);
console.log(rect.constructor.name);

function regularFunction() {
    console.log(this);
}

// regularFunction(); // this

const arrowFunction = () => {
    console.log(this);
}

arrowFunction();

const obj = {
    regularMethod: function () {
        console.log(this);
    },
    arrowMethod: () => {
        console.log(this);
    }
};

obj.regularMethod();
// obj.regularMethod;

obj.arrowMethod();

const sum = (a, b) => a + b;

console.log(sum.length);

function func(a, b, c) {
    console.log(arguments.length);
}

func(1, 2, 3);