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
grades = [1,3,3,3,4,2,5,5,2]
def haker(grades, token):    
    hacked_grades = grades.copy()
    max_grades = max(hacked_grades)
    min_grades = min(hacked_grades)
    for i, val in enumerate(hacked_grades):
        if max_grades == min_grades:
            return None
        if token == 'F':
            if val == min_grades:
                hacked_grades[i] = max_grades
        if token == 'E':
            if val == max_grades:
                hacked_grades[i] = min_grades
    return hacked_grades
print(grades)
token = str(input("Enter 'F' for friends and 'E' for enemy: ").upper())
new_grades = haker(grades, token)
print(new_grades)
        