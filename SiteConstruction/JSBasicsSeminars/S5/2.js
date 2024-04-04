// Задание 3:

// ```
const object = {
    key1: {
        key1: 1,
        key2: 2,
        key3: 3,
    },
    key2: {
        key1: 4,
        key2: 5,
        key3: 6,
    },
    key3: {
        key1: 7,
        key2: 8,
        key3: 9,
    },
}
let sumNumbers = 0;
for (const key in object) {
    for (const key2 in object[key]) {
        sumNumbers += object[key][key2];
    }
}
console.log(sumNumbers);
// ```

// Найдите сумму всех чисел, приведенного объекта.
const obj = {
    iodsuf: {
        asd: 1,
        zxc: {
            khvxc: {
                ncxvm: 9,
            }
        },
        qwd: 3,
    },
    gerg: {
        joij: {
            shdjk: 100
        },
        kjn: 5,
        iyu: 6,
    },
    xcnkv: {
        oirje: 7,
        iuhdv: 8,
    },
    idb: 1000,
};
function sum(obj) {
    let curr = 0;
    for (const key in obj) {
        if (typeof obj[key] === 'number') {
            curr += obj[key];
        } else {
            curr += sum(obj[key]);
        }
    }
    return curr;
}
console.log(sum(obj));

// Тайминг: 20 минут