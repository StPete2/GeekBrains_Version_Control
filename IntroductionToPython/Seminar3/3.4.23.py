# №3.4[23]. Дан список, состоящий из целых чисел. Напишите программу, 
# которая сформирует список из тех элементов, которые больше предыдущего 
# (элемента с предыдущим номером) 
# Примечание: Пользователь может вводить значения списка или список задан изначально.
#     Примеры/Тесты:
#     Input: [0, -1, 5, 2, 1]
#     Output: [5]

#     Input: [-2, -1, 5, 2, 3]
#     Output: [-1, 5, 3]
# [*] Усложнение: Запишите алгоритм в одну строку, используйте Comprehension
# list1 = [-2, -1, 5, 2, 3]
# list2 = []
# for i in range(1, len(list1)):
#     if list1[i] > list1[i-1]:
#         list2.append(list1[i])        
# print(list2)

list3 = [-2, -1, 5, 2, 3]
list4 = []
# for i in range(len(list3)-1):
#     if list3[i]<list3[i+1]:
#         list4.append(list3[i+1])
# print(list4)
print([list4.append(list3[i+1]) for i in range(len(list3)-1) if list3[i]< list3[i+1]])
