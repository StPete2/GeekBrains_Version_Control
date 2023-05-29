# 3.2[18]: Требуется найти в списке целых чисел самый близкий по величине элемент
# к заданному числу X.  Пользователь вводит это число с клавиатуры,
# список можно считать заданным. Введенное число не обязательно содержится в списке.
# Если в списке несколько чисел "равноблизких" к заданному числу X, то выводим
# первое встретившееся.

#     Примеры/Тесты:
#     Input: [10, 5, 7, 3, 3, 2, 5, 7, 3, 8], X = 0
#     Output: 2
#     Input: [10, 5, 7, 3, 3, 2, 5, 7, 3, 8], X = 9
#     Output: 10
list1 = [10,5,7,3,3,2,5,7,3,8]
x = int(input("Введите целое число: "))
if list1.__contains__(x):
    print("Искомое число встречается в списке. Это число {}".format(x))
else:
    difference = 0
    minDifference = 99999
    numberOfMinDifference = 0
    for i in range(len(list1)):
        if x < list1[i]:
            difference = list1[i] - x
            if minDifference > difference:
                minDifference = difference
                numberOfMinDifference = list1[i]
        if x > list1[i]:
            difference = x - list1[i]
            if minDifference > difference:
                minDifference = difference
                numberOfMinDifference = list1[i]
    print("Искомое число в списке не встречается. Ближайшим к нему является число {}".format(numberOfMinDifference))


