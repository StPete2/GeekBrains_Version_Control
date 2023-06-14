def func(n):
    if 5 <= n <= 20:
        return 'овец'
    elif n % 10 == 1:
        return 'овца'
    elif n % 10 in (2, 3, 4):
        return 'овцы'
    else:
        return 'овец'
 
 
n = int(input("Введите число: "))
m = len(str(n))
for i in range(1, n + 1):
    print(f'{i:>{m}} {func(i)}')
