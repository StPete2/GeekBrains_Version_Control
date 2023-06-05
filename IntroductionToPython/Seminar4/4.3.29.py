# №4.3[29]. Для натурального n создать список, состоящий из элементов 
# последовательности 3n + 1.
    
#     Пример:
#     - Для n = 6: [1, 4, 7, 10, 13, 16, 19]
    
#     Усложнение:
#     Создать список, где указанные числа будут стоять на соответствующих индексах,
#     остальные элементы сделать нулевыми, т.е. для индекса 1, значение 1, 
#     для индекса 4, значение 4 и т.п.
#     Пример:
#     - Для n = 6: [0,1,0,0,4,0,0,7,0,0,10]
# *** Решение № 1 ***
# n = int(input("Введите натуральное число N: "))
# output = ''
# if n == 0:
#     output = '1'
# else:
#     for i in range(n+1):
#         output = output + str(i*3 + 1) + ", "
# print(output)

# *** Решение № 2 ***
n = int(input("Введите натуральное число N: "))
list1 = []
for i in range(n+1):
    list1.append(3*i + 1)
print(list1)

# *** Решение усложненное *** 
n = int(input("Введите натуральное число N: "))
list1 = []
for i in range(n+1):
    list1.append(3*i + 1)
list2 = []
print(len(list1))
for i in range(0,(list1[n]+1)):
    if i not in list1:
        list2.append(0)
    else:
        list2.append(i)
print(list2)

# *** Решение усложенное № 2 ***
n = int(input("Введите натуральное число N: "))
list3 = [0]*(3*n+2)
for i in range(n+1):
    x = 3*i + 1
    list3[x] = x
print(list3)

n = int(input("Введите натуральное число N: "))
list4 = []
for i in range(n+1):
    list4.append(0)
    list4.append(3*i + 1)    
    list4.append(0)
list4.pop()
print(list4)