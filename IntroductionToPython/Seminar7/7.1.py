# №7.1[###]. Дан текстовый csv файл. Разделитель данных #.
# Каждая строка файла представляет собой запись вида ФИО
# Например:
# Иванов#Иван#Иванович
# Петров#Петр#Петрович
# Соколов#Илья#Григорьевич

# 1) Необходимо вывести эти данные на экран построчно в виде:
# Иванов Иван Иванович
# Петров Петр Петрович
# 2) записать эти данные в список вида: [['Иванов', 'Иван', 'Иванович'], ['Петров', 'Петр', 'Петрович']...]

# [*] Усложнение. Файл находится в поддиретории data текущей директории. 
# Сформировать путь к нему с использованием os.path и pathlib
# MAIN_DIR_OP1 = abspath(dirname(__file__))

import os
import os.path as path1
from os import getcwd
from os.path import abspath
MAIN_DIR = path1.abspath(path1.dirname(__file__))
file_name = path1.join(MAIN_DIR, "data1.txt")

# print(os.getcwd())
# print(MAIN_DIR)

with open("data1.txt", mode = "r", encoding="utf-8") as file:
    result_list = list()
    for line in file:
        last_name, first_name, parent = line.strip().split("#")
        # print(last_name, first_name, parent) # выводит без пробелов после распаковки
        # print(*line.strip().split("#")) 
# если поставить звездочку, то произойдет распаковка
        list1 = [last_name, first_name, parent] # записывает в список   
        result_list.append(list1) # записывает в список списков
    print(result_list)
    # for item in result_list:
    #     # str1 = item[0]+ " " + item[1][0] + "." + item[2][0] + "."
    #     # str1 = f"{item[0]} {item[1][0]}.{item[2][0]}."
    #     last_name, first_lit, parent_lit = item
    #     # print(str1)
    #     print(f"{last_name} {first_lit[0]}.{parent_lit[0]}.")
    for last_name, first_lit, parent_lit in result_list:
        str1 = f"{last_name} {first_lit[0]}.{parent_lit[0]}."
        print(str1)

# file_name2 = path1.join(MAIN_DIR, "Results", "Names.txt")
# with open(file_name2, mode="wt", encoding="utf-8") as result_file:
#     for last_name, first_lit, parent_lit in result_list:
#         str1 = f"{last_name} {first_lit[0]}.{parent_lit[0]}.\n"
#         result_file.write(str1)
        



# №7.2[###]. Продолжение предыдущей задачи
# Данные в списке [['Иванов', 'Иван', 'Иванович'], ['Петров', 'Петр', 'Петрович']...]
# необходимо преобразовать к виду:
# Иванов И.И.
# Петров П.П.
# Полученные строки записать в новый файл. Файл должен находиться в поддиретории
# rezults.

# [*] Усложнение. Данные необходимо записать в два разных файла:
# В первый - в виде Иванов И.И.
# Во второй - в виде Иванов-И-И
