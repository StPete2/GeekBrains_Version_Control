a = {1:10, 2:20, 3:30}
b = [[i,a[i]] for i in a] # [[1, 10], [2, 20], [3, 30]]
c = [a[i] for i in a] # [10,20,30]
print (c)

d = [j for i in b for j in i] # [1, 10, 2, 20, 3, 30]
print (d)

# for i in b:
#     for j in i:
#         c.append(j)

a = {1:10, 2:20, 3:30}
b = [i*a[i] for i in a] # [10, 40, 90]
# Здесь берется ключ из словаря, а в генерируемый список добавляется
# произведение ключа на его значение.
print(b)