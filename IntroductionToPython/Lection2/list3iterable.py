list1 = [i for i in range(1,10) if i%2 == 0] # [2,4,6,8]
list2 = [(i,i) for i in range(1,10) if i%2 == 0] # [(2,2), (4,4), (6,6), ...]
list3 = [i*2 for i in range(11) if i%2 == 0] # [0,4,8,12,16,20]
print(list1)
print(list2)
print(list3)
list4 = [(i, i*i) for i in range (1,10)]
print(list4)
a = 'str1'
b = 'str2'
print(a+b)