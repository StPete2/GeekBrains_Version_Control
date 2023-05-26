a = {1,2,3,5,8}
b = {2,5,8,13,21}
c = a.copy()
print(c)
u = a.union(b)
print(u)
i = a.intersection(b) # {8,2,5}
print(i)
dl = a.difference(b) # {1,3}
dr = b.difference(a) # {13,21}
print(dl, dr)
q = a.union(b).difference(a.intersection(b)) # {1,21,3,13} начинаем со скобок! потом от начала
print(q)