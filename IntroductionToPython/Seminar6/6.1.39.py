# №6.1[39]. Даны два списка чисел. Требуется вывести те элементы первого списка ,
# которых нет во втором списке.
# Создайте функцию.
# Аргументы: два списка целых чисел
# Возвращает: список элементов (смотри условие)
# Примеры/Тесты:
# <function_name>([3, 1, 3, 4, 2, 4, 12], [4, 15, 43, 1, 15, 1] ) -> [2, 3, 12]
# <function_name>([3, 4, 1, 5, 1, 3, 10, 4, 9, 5], [9, 6, 6, 5, 10, 1, 10, 9, 1, 5] ) -> [3,4]

# [*] Усложнение. Элементы необходимо возвращать в том порядке, в котором они
#  находятся в первом списке, с учетом повторений

# Примеры/Тесты:
# <function_name>([3, 1, 3, 4, 2, 4, 12], [4, 15, 43, 1, 15, 1] ) -> [3, 3, 2, 12]
# <function_name>([3, 4, 1, 5, 1, 3, 10, 4, 9, 5], [9, 6, 6, 5, 10, 1, 10, 9, 1, 5] ) -> [3, 4, 3, 4]

def difference_list(list1: list, list2: list) -> list:
    set_list1 = set(list1)
    set_list2 = set(list2)
    return list(set_list1.difference(set_list2))

print(difference_list([3, 1, 3, 4, 2, 4, 12], [4, 15, 43, 1, 15, 1]))

def difference_list2(list1: list, list2: list) -> list:
    set_list2 = set(list2)
    new_list = []
    for item in list1:
        if item not in set_list2:
            new_list.append(item)
    return new_list
print(difference_list2([3, 4, 1, 5, 1, 3, 10, 4, 9, 5], [9, 6, 6, 5, 10, 1, 10, 9, 1, 5]))

# from time import perf_counter
# t1 = perf_counter()
# t2 = perf_counter()
# t3 = t2 - t1

from random import randint
n = 100
list1 = [randint(0,n) for i in range(n)]
print(list1)
