def sumNumbers(n, y = "Hello!"): # передается значение по умолчанию! это круто! 
    # и поэтому оно не вызывается в строке 8.
    print(y)
    summa = 0
    for i in range(1, n+1):
        summa += i
    return summa
print(sumNumbers(5))
print(sumNumbers(6, "Привет!"))