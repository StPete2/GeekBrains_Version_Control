const App = {};

class User {
    #_name;
    constructor(name) {
        this.#_name = name;
    }

    getName() {
        return this.#_name;
    }
}

App.registerUser = (name, email, password) => {
    try {
        if (!name || !email || !password) {
            throw new Error('Not all data specified');
        }
        const user = new User(name);

        const userData = {
            name: user.getName(),
            email,
            password
        };
        console.log('Пользователь успешно зарегистрирован', user.getName());
        console.log('Дополнительные данные пользователя', userData);
    } catch (error) {
        console.error('Ошибка регистрации: ', error.message);
    } finally {
        console.log('Завершение регистрации пользователя');
    }
}

App.registerUser('John Smith', 'email@email.com', 'password');
App.registerUser('Clara', null, 'pass');