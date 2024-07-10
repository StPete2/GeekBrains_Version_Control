/*
Задание 1: 
Давайте создадим класс для управления банковским счетом. В этом классе будет 
приватное свойство для хранения текущего баланса, а также методы для внесения 
и снятия денег со счета.
Необходимо реализовать класс BankAccount, в нем:
1. Приватное свойство #balance, которое инициализируется значением 0 и 
представляет собой текущий баланс счета.
2. Геттер balance, который позволит получить информацию о текущем балансе.
3. Метод deposit(amount), который позволит вносить средства на счет. 
Убедитесь, что сумма внесения не отрицательная, что значение является 
нормальным числом и дробная часть не превышает двух знаков, в противном случае 
выбрасывайте соответствующую ошибку.
4. Метод withdraw(amount), который позволит снимать средства со счета. 
Убедитесь, что сумма внесения не отрицательная, что значение является 
нормальным числом и дробная часть не превышает двух знаков, и сумма снятия 
не может превышать текущий баланс аккаунта в противном случае выбрасывайте 
соответствующую ошибку.
*/

class BankAccount {
    #balance = 0;
    get balance() {
        return this.#balance;
    }

    getBalance() {
        return this.#balance;
    }

    deposit(amount) {
        this.#correctAmount(amount);
        return this.#balance = Math.round((this.#balance + amount) * 100) / 100;
    }

    withdraw(amount) {
        this.#correctAmount(amount);
        if (amount > this.#balance) {
            throw new Error("Withdrawn amount exceeds the balance");
        }
        return this.#balance = Math.round((this.#balance - amount) * 100) / 100;
    }

    #correctAmount(amount) {
        if (typeof amount !== "number") {
            throw new Error("Amount is not a number");
        }
        const digitsAfterPoint = amount.toString().includes(".")
            ? amount.toString().split(".").pop().length
            : 0;
        // if (typeof amount !== "number") {
        //     throw new Error("Amount is not a number");
        if (!Number.isFinite(amount)) {
            throw new Error("Can't deposit Infinity, sorry :-)");
        } else if (amount < 0) {
            throw new Error("Can't deposit a negative amount");
        } else if (amount == 0) {
            throw new Error("Please, deposit a positive amount");
        } else if (
            digitsAfterPoint !== 0 &&
            digitsAfterPoint !== 1 &&
            digitsAfterPoint !== 2
        ) {
            throw new Error("Please, deposit a valid amount");
        }
    }
}

const bankAccount = new BankAccount();
console.log(bankAccount.balance);

bankAccount.deposit(100);
console.log(bankAccount.balance);

bankAccount.withdraw(50);
// console.log(bankAccount.balance);
console.log(bankAccount.getBalance());

bankAccount.deposit(1.23);
console.log(bankAccount.balance);

bankAccount.withdraw(12.02);
console.log(bankAccount.balance);
