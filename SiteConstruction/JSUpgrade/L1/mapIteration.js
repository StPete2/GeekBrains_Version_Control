let recipeMap = new Map([
    ["cucumber", 500],
    ["tomato", 200],
    ["onion", 50],
]);

console.log(recipeMap);

for (let vegetable of recipeMap.keys()) {
    console.log(vegetable);
}

for (let amount of recipeMap.values()) {
    console.log(amount);
}

for (let entry of recipeMap) {
    console.log(entry);
}

recipeMap.forEach((value, key, map) => {
    console.log(`${key}: ${value}`);
});
