fetch("https://api.nbrb.by/exrates/rates?periodicity=0")
    .then((response) => response.json())
    .then((json) => console.log(json));
// .then((parseResult) => {
//     parseResult.forEach(element => {
//         console.log(element);
//     });
// })

const divEl = document.querySelector('div.container');