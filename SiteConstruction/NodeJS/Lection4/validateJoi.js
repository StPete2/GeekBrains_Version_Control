const Joi = require('joi');
const schema = Joi.string();

const result = schema.validate('3');
// console.log(result.error.details);
// console.log(JSON.stringify(result, null, 2));
// console.log(result);
if (result.error) {
    console.log(result.error.details);
} else {
    console.log(result);
}

const schema2 = Joi.object({
    id: Joi.number().required(),
    title: Joi.string().min(5).required(),
    content: Joi.string().min(10).required(),
});

const result2 = schema2.validate({
    id: 1,
    title: '1',
    content: '1',
})

console.log(result2.error.details);