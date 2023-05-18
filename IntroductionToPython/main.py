# print(5, 8, 6)
# n = 5
# print(n)
# m = None
# print(m)
f = 'string'
f2 = "string2"
print(f, f2)
print(f"{f}, {f2}")

# l = 5
# print(type(l))
# o = 'print"etwas"\''
# print(o)
# ctrl+k+c
# ctrl+k+u

# a = 5
# b = 6.78 #что это было?
# c = 'string'
# print(a, ' - ', b, '-', c)
# print(f"{a} - {b} - {c}")
# print("{} - {} - {}".format(a,b,c))
# print('Введите первое число: ')
# d = int(input())
# e = int(input('Введите второе число: '))
# print(d, '+', e, '=', d+e)

# a = 5.9898
# b = 3.23
# print(round(a*b, 3))

# a = 1<4
# print (a)

# a = 'qwe'
# b = 'qwe'
# print(a==b)
# a = 1 ==4
# print (a)
# a = 1!=2
# print (a)

username = str(input('Введите имя: '))
if username == 'Маша':
    print('Ура! Это же Маша')
elif username == 'Ильнар':
    print('Ильнар - топ)')
else:
    print('Привет,', username)

n = int(input('Введите число: '))
if n%2 == 0 and n%3 == 0:
    print('Число кратно 6')
else:
    print('Число не кратно 2 и 3 одновременно')
