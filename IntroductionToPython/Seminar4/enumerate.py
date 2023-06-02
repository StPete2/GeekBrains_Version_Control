list1 = [11,12,23,34,45,56] # индекс элемента не нужен
# for item in list1:
#     if item > 30:
#         print(item)

# for indx in range(len(list1)):
#     if list1[indx]>30:
#         print(list1[indx])

for item in enumerate(list1):
    print (item)

for indx, val in enumerate(list1):
    print(indx, val)

[idx for idx, val in enumerate(list1) if val > 30] #comprehension
# условие на значение, а результирующий список - индекс!
