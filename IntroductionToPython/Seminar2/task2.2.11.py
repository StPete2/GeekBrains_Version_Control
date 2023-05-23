# №2.2[11]. Дано натуральное число A > 1. Определите, каким по счету числом Фибоначчи 
# оно является, то есть выведите такое число n, что φ(n)=A. 
# Если А не является числом Фибоначчи, выведите число -1.

#     Примеры/Тесты:
#     5 -> в ряду Фибоначчи 5 имеет порядковый номер 6

checkingFibonacciNumber = int(input('Введите число, проверяемое на соответствие ряду Фибоначчи: '))
firstFibonacciNumber = 0
secondFibonacciNumber = 1
sumF1andF2 = 0
counter = 2
while sumF1andF2 < checkingFibonacciNumber:
    sumF1andF2 = firstFibonacciNumber + secondFibonacciNumber
    firstFibonacciNumber = secondFibonacciNumber
    secondFibonacciNumber = sumF1andF2
    counter = counter + 1
    print(sumF1andF2)
else:
    if checkingFibonacciNumber == sumF1andF2:
        print(f"Введенное число является числом Фибоначчи под номером {counter}")
    else:
        print(-1)