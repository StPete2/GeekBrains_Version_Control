# №3.1[17]. Дан список чисел. Определите, сколько в нем встречается различных чисел.
# Примечание: Пользователь может вводить значения списка или список задан изначально.
#     Примеры/Тесты:
#     [1, 1, 2, 0, -1, 3, 4, 4] -> 6
#     [1, 1, 2, 0, 1, 2, 1, 2]  -> 3

# list1 = [1,1,2,0,-1,3,4,4]
# emptyList = []
# for item in list1:
#     if item not in emptyList:
#         emptyList.append(item)
# print(emptyList)
# print(len(emptyList))

# list2 = [1,2,3,3,2,1,-4,5]
# resultList = set(list2)
# # print(resultList)
# # print(len(resultList))
# # update
# print(len(set(list2)))

# №3.1[17]. Дан список чисел. Определите, сколько в нем встречается различных чисел.
# Примечание: Пользователь может вводить значения списка или список задан изначально.
#     Примеры/Тесты:
#     [1, 1, 2, 0, -1, 3, 4, 4] -> 6
#     [1, 1, 2, 0, 1, 2, 1, 2]  -> 3
list1 = [1, 1, 2, 0, -1, 3, 4, 4]
# print(len(set(list1)))
emptyList1 = []
for i in list1:
    if i not in emptyList1:
        emptyList1.append(i)
print(len(emptyList1))