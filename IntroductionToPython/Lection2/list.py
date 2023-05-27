# list1 = []
# list1 = list()
list1 = [1,2,3 ,8]
# print(list1)
# list2= [1,5,7,9]
# print(*list2) # удаляет все скобки и запятые!

# for i in list2:
#     print(i)
print(list1[-1]) # выводит символ с конца списка под указанным номером
# print(len(list1))
list1.append(9)
print(list1)

list3 = []
print(list3)
for i in range(5): # идет до 4! только
    list3.append(i)
print(list3)
list3.pop() # удаление последнего элемента списка
print(list3)