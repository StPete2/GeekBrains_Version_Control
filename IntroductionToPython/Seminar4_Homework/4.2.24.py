# 4.2[24]: В фермерском хозяйстве в Карелии выращивают чернику. Она растет на 
# круглой грядке, причем кусты высажены только по окружности. Таким образом,
# у каждого куста есть ровно два соседних. Всего на грядке растет N кустов. 
# Собирающий модуль за один заход, находясь непосредственно перед некоторым кустом,
# собирает ягоды с этого куста и с двух соседних с ним.
# Напишите программу для нахождения максимального числа ягод, которое может собрать
# за один заход собирающий модуль, находясь перед некоторым кустом.
# На входе задано количество ягод на каждом кусте. Не обязательно вводить их с
# клавиатуры, можно задать непосредственно в коде программы

# Примеры/Тесты:
# Input1: 1, 2, 3, 4, 5, 6, 7, 8
# Output1: Макс. кол-во ягод 21, собрано для куста 7

# Input1: 11, 92, 1, 42, 15, 12, 11, 81
# Output1: Макс. кол-во ягод 184, собрано для куста 1
blueberry_bushes = [11, 92, 1, 42, 15, 12, 11, 81]
max_number_of_berries = 0
current_number_of_berries = 0
index_of_max_number_of_berries = 0
blueberry_bushes.insert(0, blueberry_bushes[len(blueberry_bushes)-1])
blueberry_bushes.insert(len(blueberry_bushes), blueberry_bushes[1])
# print(blueberry_bushes)
for i in range(1,len(blueberry_bushes)-1):
    current_number_of_berries = blueberry_bushes[i] + blueberry_bushes[i-1] + blueberry_bushes[i+1]
    if current_number_of_berries > max_number_of_berries:
        max_number_of_berries = current_number_of_berries
        index_of_max_number_of_berries = i    
    current_number_of_berries = 0
print(f"Максимальное количество ягод {max_number_of_berries}, собрано для куста {index_of_max_number_of_berries}")

