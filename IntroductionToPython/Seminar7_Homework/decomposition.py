# Это черновой файл для отработки отдельных элементов кода.
# Его проверять не надо.

str2 = "пара-ра-рам рам-пам-папам па-ра-па-дам"
str3 = "пара-ра-рам рам-пум-пупам па-ре-по-дам"
str4 = "пара-ра-рам рам-пуум-пупам па-ре-по-дам"
str5 = "Трам-пара-папам-парам-па-пам-пам-па Пум-пурум-пу-пурум-трам-пам-па"
str6 = "Пам-парам-пурум Пум-пурум-карам"
list_str = str3.split()
vowels_set = {'а', 'е', 'у', 'о'}
vowels_dictionary = dict()
list_of_dictionaries = list()
for idx, val in enumerate(list_str):    
    for item in list_str[idx]:        
        if item in vowels_set and item not in vowels_dictionary:
            vowels_dictionary[item] = 1
        elif item in vowels_set and item in vowels_dictionary:
            vowels_dictionary[item]+=1    
    list_of_dictionaries.append(vowels_dictionary)
    print(list_of_dictionaries)
    vowels_dictionary = dict()

# (True, [{'а': 4}, {'а': 2, 'у': 2}, {'а': 2, 'е': 1, 'о': 1}])
# (True, [{'а': 4}, {'а': 4}, {'а': 4}])