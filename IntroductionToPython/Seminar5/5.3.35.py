# №5.3[35]. Напишите функцию, которая принимает число и проверяет, является ли 
# оно простым
# Напоминание: Простое число - это число, которое имеет 2 делителя нацело: 
# 1  и само число
# Если число простое - функция возвращает True, если нет - возвращает False
# Примеры/Тесты:
#     <function_name>(13) -> True
#     <function_name>(10) -> False
def simpleNumber (number):
    if isinstance(number,int):
        for devider in range (2, number//2+1):
            if number%devider == 0:
                return False
        return True
    else:
        return "Error"
result= simpleNumber(13)
result2 = simpleNumber(10)
result3 = simpleNumber("9")
print(result)
print(result2)
print(result3)

def simpleNumber2(number):
    if not isinstance(number,int):
        return "Error"
    for devider in range(2,number//2+1):
        if number%devider == 0:
            return False
    return True
result= simpleNumber2(13)
result2 = simpleNumber2(10)
result3 = simpleNumber2("9")
print(result)
print(result2)
print(result3)