list1 = [1,2,3,5,8,15,23,38]
result_list = []
for i in list1:
    if i % 2 ==0:
        result_list.append((i,i*i)) # [(2, 4), (8, 64), (38, 1444)]
print(result_list)