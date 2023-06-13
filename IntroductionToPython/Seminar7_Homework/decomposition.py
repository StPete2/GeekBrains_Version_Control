# Это черновой файл для отработки отдельных элементов кода.
# Его проверять не надо.

str3 = "пара-ра-рам рам-пум-пупам па-ре-по-дам"
str2 = "пара-ра-рам рам-пам-папам па-ра-па-дам"
list_str = str2.split()
# print(list_str)
vowels_set = set("ауое")
vowels_dictionary = dict()
for idx, val in enumerate(list_str):
    for item in list_str[idx]:
        if item in vowels_set and not vowels_dictionary:
            vowels_dictionary[item] = 1
        elif item in vowels_set and vowels_dictionary:
            vowels_dictionary[item]+=1    
    print(vowels_dictionary)
# (True, [{'а': 4}, {'а': 2, 'у': 2}, {'а': 2, 'е': 1, 'о': 1}])
# (True, [{'а': 4}, {'а': 4}, {'а': 4}])