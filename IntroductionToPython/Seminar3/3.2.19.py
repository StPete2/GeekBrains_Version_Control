# №3.2[19]. Дана последовательность из N целых чисел и число K. Необходимо сдвинуть 
# всю последовательность (сдвиг - циклический) на K элементов вправо,  
# K – положительное число.
# Примечание: Пользователь может вводить значения списка или список задан изначально.
#     Примеры/Тесты:
#     Input:   [1, 2, 3, 4, 5] k = 3
#     Output:  [4, 5, 1, 2, 3]

# list1 = [1,2,3,4,5]
# k = 3
# list2 = []
# # for i in range(k):
# #     list1.insert(0,list1[-1])
# #     print(list1)
# #     list1.pop(-1)
# #     print(list1)
# # print(list1)

# for i in range(len(list1)-k):
#     list2.append(i+k)
# print(list2)

# resultList = []
# resultList = list1[k:]+list1[:k]
# print(resultList)

# №3.2[19]. Дана последовательность из N целых чисел и число K. Необходимо сдвинуть 
# всю последовательность (сдвиг - циклический) на K элементов вправо,  
# K – положительное число.
# Примечание: Пользователь может вводить значения списка или список задан изначально.
#     Примеры/Тесты:
#     Input:   [1, 2, 3, 4, 5] k = 3
#     Output:  [4, 5, 1, 2, 3]

list1 = [1,2,3,4,5]
k = 3
resultList = []
# resultList = list1[k:]+list1[:k]
# print(resultList)

# for i in range(len(list1)-k+1):
#     resultList.append(i+k)
# for i in range(len(list1)-k):
#     resultList.append(i+1)
# print(resultList)

for i in range(k):
    list1.insert(0,list1[-1])
    print(list1)
    list1.pop(-1)
    print(list1)
print(list1)

list1 = [1,2,3,4,5]
k = 3
resultList = []

for i in range(len(list1)):
    resultList.append(list1[i-k])
    print(resultList)