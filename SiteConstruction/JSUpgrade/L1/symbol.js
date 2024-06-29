const dogID = Symbol("super dog");
// console.log(dogID);
// console.log(dogID.description);

let id = Symbol("dogID");

let buddy = {
    [id]: "SuperEtwas Dog",
};

console.log(buddy);

let buddies = {
    [Symbol("Жучка")]: "Жучка",
    [Symbol("Мурка")]: "Мурка",
    [Symbol("Таракашка")]: "Таракашка",
    elephant: "Слон",
};

console.log(buddies);

let newBuddies = {};
Object.assign(newBuddies, buddies);
buddies.cat = "Мурка";

console.log(newBuddies);
console.log(buddies);
