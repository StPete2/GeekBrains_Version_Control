# 2.3[14]: Требуется вывести все целые степени двойки (т.е. числа вида 2^k), 
# не превосходящие числа N.
    
# 	Примеры/Тесты:
#     10 ->
#     1
#     2
#     4
#     8

# ```(*)``` Усложнение. Вывод оформить в одну строку: числа выводить через запятую. 
# Для этого воспользоваться параметрами функции print

#     Примеры/Тесты:
#     10     -> 1,2,4,8,
#     10000  -> 1,2,4,8,16,32,64,128,256,512,1024,2048,4096,8192,
power = 0
number = int(input("Введите целое число: "))
powerOf2 = 2
if number <= 0:
    print("Любая степень двойки больше нуля")
elif number == 1:
    print(1)
else:
    print(1)
    while powerOf2 <= number:
        print(powerOf2)
        powerOf2= powerOf2*2
