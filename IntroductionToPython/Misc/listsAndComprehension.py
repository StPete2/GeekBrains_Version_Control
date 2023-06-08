a = [2,-2,4,-4,7,5]
b = [i**2 for i in a] # [4, 4, 16, 16, 49, 25]
print(b)

a = "lsj94ksd231 9"
b = [int(i) for i in a if '0'<=i<='9'] # [9, 4, 2, 3, 1, 9]