# 6.1[30]: Напишите программу, генерирующую элементы арифметической прогрессии
# Программа принимает от пользователя три числа :
# Первый элемент прогрессии, Разность (шаг) и Количество элементов
# Формула для получения n-го члена прогрессии: an = a1 + (n-1) * d.

# Напишите функцию
# - Аргументы: три указанных параметра
# - Возвращает: список элементов арифмитической прогрессии.

# Примеры/Тесты:
# Ввод: 7 2 5
# Вывод: [7 9 11 13 15]
# Ввод: 2 3 12
# Вывод: [2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35]
# (*) Усложнение. Для формирования списка внутри функции используйте Comprehension
# (**) Усложнение. Присвоение значений переменным a1,d,n запишите, используя
# только один input, в одну строку, вам понадобится распаковка и Comprehension 
# или map

def ArithmeticProgression(beginningNumber: int, step: int, numberOfElements: int) -> list:
    result_list = list()    
    result_list = [beginningNumber + (i-1)*step for i in range(1, numberOfElements+1)]
    return result_list
# input_data = int(input("Введите начальное значение, шаг и количество элементов прогрессии: "))
input_data = input("Введите начальное значение, шаг и количество элементов через пробел: ").split()
# print(input_data)
# input_data_int = list(map(int,input_data))
input_data_int = [int(i) for i in input_data]
beginningNumber, step, n = input_data_int
# beginningNumber = int(input("Введите начальное значение: "))
# step = int(input("Введите шаг прогрессии: "))
# n = int(input("Введите число элементов прогрессии: "))
print(ArithmeticProgression(beginningNumber,step,n))