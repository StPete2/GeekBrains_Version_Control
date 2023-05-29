# mutable and immunatable objects
# ключ словаря - можно брать hash
# словарь - это hash таблица
# hash может быть вычислен от: числа, строки, кортеж (все неизменяемые объекты), bool,
# кортеж кортежей тоже неизменяемый, а если внутри кортежа список - то hash
#  вычислить не получится.
# Ключ к словарю - имя!
dict1 = {"1": 121, (1,2,3): "Ivanov", "Petrov": [1,[1,2,3],3]}
# print(dict1)
# a = dict1["Petrov"][1][2] 
# print(a)
# for key in dict1.keys():
#     print(key)
# for val in dict1.values():
#     print(val)
for item in dict1.items():
    print(item)
# возвращает кортеж
# а вот это распаковка:
for key, val in dict1.items():
    print(key,val)