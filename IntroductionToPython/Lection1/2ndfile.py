n = 423
summa = 0
while n>0:
    x = n%10
    summa = summa + x
    n = n // 10
print(summa)

i = 0
while i < 5:
    # if i == 3:
    #     break
    i = i + 1
else:
    print("Пожалуй, хватат)")
print(i)