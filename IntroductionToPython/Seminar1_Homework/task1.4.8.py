# #### 1.4[8]. Требуется определить, можно ли от шоколадки размером n × m долек
#  отломить k долек, если разрешается сделать один разлом по прямой между дольками 
#  (то есть разломить шоколадку на два прямоугольника).
# 	Примеры/Тесты:
# 	3 2 4 -> yes
# 	3 2 1 -> no
n = int(input('Введите количество долек по длине: '))
m = int(input('Введите количество долек по ширине: '))
k = int(input('Введите количество долек, которые хотите отломить: '))
flag = False
if (k%m == 0 or k%n == 0) and k<m*n:
    flag = True
print(flag)
