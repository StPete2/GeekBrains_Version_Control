/*
Задание 2: 
Мы создаем приложение. У нас планируется два вида пользователей, обычные и 
премиум. Общие свойства этих пользователей необходимо вынести в базовый класс.

1. Создайте базовый класс User с базовой информацией (имя и фамилия, которые 
должны создаваться при создании экземпляра класса).
2. Создайте классы PremiumUser и RegularUser, которые наследуются от User. Класс
PremiumUser должен иметь свойство premiumExpiration (дата истечения срока
действия премиум аккаунта, должно задаваться при создании объекта), а у 
RegularUser такого свойства нет.
3. Создайте функцию getAccountInfo(user), которая принимает объект класса User 
и возвращает информацию о наличии и сроке действия премиум-аккаунта. Необходимо
использовать instanceof для проверки типа переданного пользователя и дать 
соответствующий ответ из функции (в свободном формате).
*/

class User {
    constructor(name, familyName) {
        if (this.constructor === User) {
            throw new Error("Not possible to create an abstract user");
        }
        this.name = name;
        this.familyName = familyName;
    }
}

class PremiumUser extends User {
    constructor(name, familyName, premiumExpiration) {
        super(name, familyName);
        this.premiumExpiration = premiumExpiration;
    }
}

class RegularUser extends User {
    // constructor(name, familyName) {
    //     super(name, familyName);
    // } // можно не писать, так как вызовется автоматически
}

function getAccountInfo(user) {
    if (user instanceof PremiumUser) {
        console.log(`${user.name} is a premium user. Expiration: ${user.premiumExpiration}`);
    } else if (user instanceof RegularUser) {
        console.log(`${user.name} is a regular user.`);
    } else {
        console.log('Error');
    }
}

const premiumUser = new PremiumUser("PremiumName", "PremiumFamilyName", "22.10.24");
const regularUser = new RegularUser("RegularName", "RegularFamilyName");
// const ordinaryUser = new User("Test", "TestUser");

getAccountInfo(premiumUser);
getAccountInfo(regularUser);
// getAccountInfo(ordinaryUser);

