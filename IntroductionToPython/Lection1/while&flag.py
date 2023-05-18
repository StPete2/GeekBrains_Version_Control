n = int(input('Введите целое число'))
flag = True
i = 2
while flag:
    if n%i == 0:
        flag = False 
        print(f"Минимальный делитель числа {n} равняется {i}")
    elif i>n // 2:
        print("Вы ввели простое число или число меньше 4")
        flag = False
    i = i + 1
