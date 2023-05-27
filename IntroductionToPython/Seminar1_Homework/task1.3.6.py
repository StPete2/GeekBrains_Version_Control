# #### 1.3[6]. Вы пользуетесь общественным транспортом? Вероятно, вы расплачивались 
# за проезд и получали билет с номером.Счастливым билетом называют такой билет с 
# шестизначным номером, где сумма первых трех цифр равна сумме последних трех. 
# Т.е. билет с номером 385916 – счастливый, т.к. 3+8+5=9+1+6. Вам требуется написать 
# программу, которая проверяет счастливость билета.

# 	Примеры/Тесты:
# 	385916 >>> yes
# 	123456 >>> no

# ```(*)``` **Усложнение.** Вывод результат на экран сделайте одной строкой(только 
# один print), для этого используйте тернарный оператор
ticketNumber = int(input('Введите шестизначный номер билета: '))
counter1 = 0
counter2 = 0
sumFirst3Digits = 0
sumLast3Digits = 0
while counter1 <3:
    sumFirst3Digits += ticketNumber%10
    ticketNumber//=10
    counter1 = counter1 + 1
    # print(sumFirst3Digits)
else:
    while counter2 <3:
        sumLast3Digits +=ticketNumber%10
        ticketNumber//=10
        counter2 +=1
        # print(sumLast3Digits)
if sumFirst3Digits == sumLast3Digits:
    print('Вам достался счастливый билет')
else:
    print('У Вас обычный билет')
# ticketNumber = input("Введите номер билета: ")
# print(type(ticketNumber))
# print("Yes!" if int(ticketNumber[0])+int(ticketNumber[1])+int(ticketNumber[2]) == int(ticketNumber[3])+int(ticketNumber[4])+int(ticketNumber[5]) else "No")

