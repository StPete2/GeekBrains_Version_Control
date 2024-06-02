const uuid = require('uuid'); // раньше было импортирование глобального модуля http, здесь - загрузка библиотеки.
const id = uuid.v4(); // алгоритм четвертой версии
console.log(id);
