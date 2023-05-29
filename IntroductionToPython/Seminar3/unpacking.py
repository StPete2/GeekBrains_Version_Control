list1 = [[1,2,3],2,True,4, "Ivanov"]
a,b,c,d,e = list1
print(a)
a,*d,e = list1
print(d)
a,b,_,_,e = list1
print(e)
a,*_,e = list1 # так тоже можно, центр уходит в неопределенную переменную

