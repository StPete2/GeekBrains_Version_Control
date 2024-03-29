# №64.4[45] Два различных натуральных числа n и m называются дружественными, 
# если сумма делителей числа n (включая 1, но исключая само n) равна
# числу m и наоборот.
# Например, 220 и 284 – дружественные числа.
# 220: 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 и 110, — их сумма равна 284.
# 284: 1, 2, 4, 71 и 142, — их сумма равна 220.
# Первые пары дружественных чисел:
# 220, 284; 1184, 1210; 2620, 2924; 5020, 5564; 6232, 6368
# Для заданного числа number выведите все пары дружественных чисел, 
# каждое из которых не превосходит number.
# Напишите функцию:
# Аргументы: целое число
# Печатает все пары дружественных чисел, не превосходящих аргумент.
# Каждая пара должна быть выведена только один раз (перестановка чисел новую пару
# не дает).

# Примечание:
# 1. Выделите значимые куски алгоритма и оформите их в виде функций
# 2. Задокументируйте созданные функции
# 3. Используйте type hinting

# Примеры/Тесты:
# <function_name>(300)
# 220 284
# <function_name>(10000)
# 220 284
# 1184 1210
# 2620 2924
# 5020 5564
# 6232 6368

def delitel(number: int)-> int:
    sum_del = 0
    for el in range(1,number):
        if number % el == 0:
            sum_del+=el
    return sum_del

def friendly (number: int) -> None:
    for el in range (number+1):
        second_number = delitel(el)
        if el < second_number:
            if el == delitel(second_number):
                print(el, second_number)
friendly(300)

def delitel(number: int)-> int:
    sum_del = 0
    for el in range(1, number):
        if number % el == 0:
            sum_del += el
    return sum_del

def frendly(number: int) -> None:
    for el in range(number + 1):
        second_number = delitel(el)
        if el < second_number and el == delitel(second_number):
            print(el, second_number)

frendly(300)