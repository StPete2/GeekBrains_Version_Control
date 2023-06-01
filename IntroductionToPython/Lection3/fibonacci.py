def fib(n):
    if n == 1:
        return 0
    if n in [2,3]:
        return 1
    return fib(n-1) + fib(n-2)

list1 = []
for i in range(1,10):
    list1.append(fib(i))
print(list1)
