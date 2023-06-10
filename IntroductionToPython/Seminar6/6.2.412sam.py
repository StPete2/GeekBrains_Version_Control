# №6.2[41] Дан список, целых чисел.
# Напишите функцию, которая определит те элементы списка, у которых два соседних и,
# при этом, оба соседних элемента меньше данного.
# Функция
# Аргументы: список целых чисел
# Возвращает: список элементов (смотри условие)

# Примеры/Тесты:
# <function_name>([1, 3, 3, 3, 5]) -> [5]
# <function_name>([1, 5, 1, 6, 1]) -> [5,6]
# <function_name>([7, 5, 1, 6, 8]) -> [8]
# <function_name>([8, 1, 5, 4, 5]) -> [8,5]

# def bigger_than_2neighbours (list1: list) -> list:
#     result_list = list()
#     for i in range (len(list1)-1):
#         if list1[i] > list1[i+1] and list1[i] > list1[i-1]:
#             result_list.append(list1[i])
#     i = len(list1)-1
#     if list1[i]>list1[i-1] and list1[0] < list1[i]:
#         result_list.append(list1[i])
#     return result_list

# print(bigger_than_2neighbours([1, 3, 3, 3, 5]))
# print(bigger_than_2neighbours([8, 1, 5, 4, 5]))

def bigger_than_2neighbours2 (list1: list) -> list:
    # result_list = dict()    
    result_list = list()
    for i in range (len(list1)):
        if list1[i] > list1[i-len(list1)+1] and list1[i] > list1[i-1]:
            result_list.append(f"{i}: {list1[i]}")
            # result_list[i] = list1[i]    
            # result_list[f"Индекс = {i}"] = f"Значение = {list1[i]}"    
    return result_list

print(bigger_than_2neighbours2([1, 3, 3, 3, 5]))
print(bigger_than_2neighbours2([8, 1, 5, 4, 5]))
