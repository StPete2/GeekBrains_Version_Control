# №1.3[5]. Вагоны в электричке пронумерованы натуральными числами, начиная с 1
# (при этом иногда вагоны нумеруются от «головы» поезда, а иногда – с «хвоста»;
# это зависит от того, в какую сторону едет электричка).
# В каждом вагоне написан его номер. Витя сел в i-й вагон от головы поезда и 
# обнаружил, что его вагон имеет номер j.
# Он хочет определить, сколько всего вагонов в электричке.
# Напишите программу, которая будет это делать или сообщать, что без дополнительной 
# информации это сделать невозможно.
# Примеры/Тесты:
#     i=3 j=4 (ввод на разных строках) -> В поезде 6 вагонов
#     i=6 j=2 (ввод на разных строках) -> В поезде 7 вагонов
#     Определите сами, в каких случаях нельзя определить кол-во вагонов
i = int(input('Введите номер вагона от головы поезда: '))
j = int(input('Введите фактический номер вагона: '))
if i == j:
    print('Посчитать количество вагонов не возможно')
else:
    print(f'В поезде {i+j-1} вагонов')