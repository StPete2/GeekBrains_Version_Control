t = ()
print(type(t))

t = (1,2,3,) #, и () - признаки кортежа
print(t)

v = [1,2,3,4]
print(v)
print(type(v))
v[0] = 2
v = tuple(v)
print(v)
# a, b = 1, 2
# print(a,b)

a,b,c,d = v
print(a,b,c,d)
for i in range(len(v)):
    print(i, v[i])

t = tuple(['red', 'green', 'blue']) # это распаковка кортежа с переводом в кортеж из списка
print(t)
t = ('red', 'green', 'blue',)
print(t)