# 5.1[26]: Напишите рекурсивную функцию для возведения числа a в степень b. 
# Разрешается использовать только операцию умножения. Циклы использовать нельзя
# Примеры/Тесты:
# <function_name>(2,0) -> 1
# <function_name>(2,1) -> 2
# <function_name>(2,3) -> 8
# <function_name>(2,4) -> 16
def power(a:int,b: int) -> int:
    if b == 0:
        return 1
    elif b == 1:
        return a
    else:
        return a*power(a,b-1)
a = int(input("Введите число: "))
b = int(input("Введите степень числа: "))
print(power(a,b))