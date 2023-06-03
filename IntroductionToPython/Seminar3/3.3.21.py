# №3.3[21]. Напишите программу для печати всех уникальных значений в списке словарей.
# Примечание: Список словарей задан изначально. Пользователь его не вводит
# Обратите внимание, что в словарях может быть один или несколько элементов
#     Примеры/Тесты:
#     Input:  [{"V": "S001", "X": "D009"}, {"V": "S002"}, {"VI": "S001"},
# {"VI": "S005", "XI": "D011"}, {"VII": " S005 "}, {" V ":" S009 "}, 
# {" VIII ":" S007 ", "XII": "D001"}]
#     Output: {'S005', 'S002', 'S007', 'S001', 'S009'}
# [*]  Усложнение. Проверку уникальности строк сделайте без учета пробелов до и после
#  значимой части строки
# [**] Усложнение. Запишите алгоритм в одну строку, используйте Comprehension
list1 = [
    {"V": "S001", "X": "D009"},
    {"V": "S002"}, 
    {"VI": "S001"},
    {"VI": "S005", "XI": "D011"}, 
    {"VII": " S005 "}, 
    {" V ":" S009 "}, 
    {" VIII ":" S007 ", "XII": "D001"}
    ]
# resultSet = set()
# for item in list1:
#     for key,val in item.items():
#         resultSet.add(val.strip())
# print(resultSet)


resultSet2 = [val.strip() for item in list1 for key,val in item.items()]
print(resultSet2)
resultSet2 = {val.strip() for item in list1 for key,val in item.items()}
print(type(resultSet2))
print(resultSet2)

resultSet2 = {val.strip():key for item in list1 for key,val in item.items()}
print(type(resultSet2))
print(resultSet2)
