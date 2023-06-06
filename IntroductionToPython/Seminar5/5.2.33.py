# №5.2[33]. Хакер Василий получил доступ к классному журналу и хочет заменить 
# все свои минимальные оценки на максимальные.
# Напишите функцию, которая заменяет оценки, переданные в виде списка, 
# но наоборот: все максимальные – на минимальные.
# Функция должна возвращать новый список оценок
# Примечание: Обратите внимание на side effects функции.
# Примеры/Тесты:
#     <function_name>([1, 3, 3, 3, 4, 2, 5, 5, 2]) -> [1, 3, 3, 3, 4, 2, 1, 1, 2]
# [*] Усложненение: Если ни одна оценка не была заменена, функция должна вернуть
# None
# Примеры/Тесты:
#     <function_name>([3, 3, 3, 3, 3, 3, 3, 3, 3]) -> None
# [**] Усложненение: Добавьте параметр в функцию, который определит как будут
# заменены оценки:
# Друзьям минимальные на максимальные, Врагам - наоборот.
# Примеры/Тесты:
#     grades = [1, 3, 3, 3, 4, 2, 5, 5, 2]
#     <function_name>(grades, "friend") -> [5, 3, 3, 3, 4, 2, 5, 5, 2]
#     <function_name>(grades, "enemy")  -> [1, 3, 3, 3, 4, 2, 1, 1, 2]
def haker(grades):
    newGrades = grades.copy()
    maxGrades = max(newGrades)
    minGrades = min(newGrades)
    # for i in range(len(grades)):
    for i, val in enumerate(newGrades):
        if val == maxGrades:#newGrades[i] == maxGrades:
            newGrades[i] = minGrades
        # if grades[i] == max_grades:
        #     grades[i] = min_grades
    return newGrades
num = [1, 3, 3, 3, 4, 2, 5, 5, 2]
print(num)
grades = haker(num)
print(grades)

# def haker(grades):
#     new_grades = grades.copy()
#     max_grades = max(new_grades)
#     min_grades = min(new_grades)
#     if (max_grades == min_grades): 
#         return None
#     for i,item in enumerate(new_grades):
#         if (new_grades[i] == max_grades):
#             new_grades[i] = min_grades
#     return new_grades

# num = [3, 3, 3, 3, 3, 3, 3, 3, 3]
# print(num)
# gr = haker(num)
# print(num)
# print(gr)