# 5.2[28]: Напишите рекурсивную функцию sum(a, b), возвращающую сумму двух целых
# неотрицательных чисел. Из всех арифметических операций допускаются только +1 и -1. 
# Циклы использовать нельзя
# Примеры/Тесты:
# <function_name>(0,0) -> 0
# <function_name>(0,2) -> 2
# <function_name>(3,0) -> 3
def sum_rec(a:int, b: int) -> int:
    if a == 0:
        return b
    elif b == 0:
        return a
    else:                
        if a>b:            
            return 1+sum_rec(a,b-1)
        else:
            return 1+sum_rec(a-1,b)
print(sum_rec(3,0))
print(sum_rec(0,2))
print(sum_rec(0,0))
print(sum_rec(15,7))

def sum_rec2(a, b):
    if a == 0:
        return b    
    return sum_rec2(a-1, b+1)
print(sum_rec2(5,2))
