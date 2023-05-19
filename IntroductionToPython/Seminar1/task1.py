a = 2016
res = a %4 == 0 and a %100 !=0
res2 = a%400 == 0
resFinal = res or res2
print(resFinal)
if resFinal:
    print('Yes')
else:
    print('No')

res3 = 'YES' if a%4 == 0 and a %100 !=0 or a %400 == 0 else 'NO'
print(res3)

print('YES!') if a%4 ==0 and a %100!=0 or a %400 ==0 else 'No!'