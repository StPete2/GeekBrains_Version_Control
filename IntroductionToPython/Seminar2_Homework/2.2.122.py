# Подсмотрено у эталонного решения после сдачи работы... А так можно было решить?)

x = int(input())
y = int(input())
for i in range(x):
    for j in range(y):
        if x == i + j and y == i * j:
            print(i, j)