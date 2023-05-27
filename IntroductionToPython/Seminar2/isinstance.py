str1 = "123456"
print(isinstance(str1, str)) # проверяем переменную str1 на соответствие типу str
# возвращает значение True или False
if isinstance(str1, str):
    print("Строка")
elif isinstance(str1, int):
    print("Число")
