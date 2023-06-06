# 4.1[22]: Даны два неупорядоченных набора целых чисел (может быть, с повторениями).
# Выдать без повторений в порядке возрастания все те числа, которые встречаются 
# в обоих наборах. Если таких чисел нет - выдать внятное диагностическое сообщение
# Наборы (списки) чисел можно считать заданными и не вводить с клавиатуры

# Примеры/Тесты:
# Input1: 2 4 6 8 10 12 10 8 6 4 2
# Input2: 3 6 9 12 15 18
# Output: 6 12     Обратите внимание: Без скобочек, в одну строку

# Input1: 2 4 6 8 10 10 8 6 4 2
# Input2: 3 9 12 15 18
# Output: Повторяющихся чисел нет
input_a = [2, 4, 6, 8, 10, 12, 10, 8, 6, 4, 2]
input_b = [3, 6, 9, 12, 15, 18]
# set_a = set(input_a)
# set_b = set(input_b)
# intersection_c = set_a.intersection(set_b)
# print(intersection_c)
result_intersection = []
for i in input_a:
    for j in input_b:
        if i == j:
            result_intersection.append(i)
set_result_intersection = set(result_intersection)
capacity_result_intersection = len(set_result_intersection)
if capacity_result_intersection == 0:
    print("Наборы чисел не имеют повторяющихся значений")
else:
    set_result_intersection = sorted(set_result_intersection)
    for i in set_result_intersection:
        print(i, end = ' ')
