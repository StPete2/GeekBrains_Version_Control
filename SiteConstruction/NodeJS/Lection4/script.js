const handlebars = require("handlebars");
const template = handlebars.compile("<p>{{someVar}}</p>");

const result = template({ someVar: "Hello!" });
console.log(result);

const templateIF = handlebars.compile(
    "{{#if bold}}<b>Hello!</b> {{else}}<p>Hello!</p> {{/if}}"
);

console.log(templateIF({ bold: true }));
console.log(templateIF({ bold: false }));

const items = [
    { name: "first item name", number: 1 },
    { name: "second item name", number: 2 },
];

const templateEach = handlebars.compile(
    "{{#each items}}<p> {{this.name}} {{this.number}} </p>{{/each}}"
);

console.log(templateEach({ items }));
