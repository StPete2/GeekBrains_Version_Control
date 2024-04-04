// Задание 4: 

// 1. Создайте объект riddle.

// 2. Добавьте свойства question со значениями(текст загадки) и 
// answer (ответ на загадку).

// 3. Создайте метод askQuestion который спрашивает у пользователя вопрос 
// question и сравнивает ответ с answer.
// В случае верного ответа, необходимо поздравить пользователя.
// В случае, если пользователь ответил неверно, необходимо подсказать, 
// подсказок может быть несколько.
// Если пользователь ответил неверно после всех подсказок, то в консоль 
// выводится текст: “вы проиграли”.
const riddle = {
    question: 'зимой и летом одним цветом',
    answer: ['ёлка', 'ель', 'елка'],
    hints: ['она зеленая', 'это на новый год', 'под ней подарки'],
    askQuestion() {
        for (let count = 0; count < 3; count++) {
            const userAnswer = prompt(this.question).toLocaleLowerCase();
            if (this.answer.includes(userAnswer)) {
                alert('Вы ответили правильно!');
                return;
            }
            alert(this.hints[count]);
        }
        alert('Вы не угадали...');
    }
};

riddle.askQuestion();
// Тайминг: 25 минут.