# 7.1[34]: Винни-Пух попросил Вас посмотреть, есть ли в его стихах ритм.
# Поскольку разобраться в его кричалках не настолько просто, насколько легко он
# их придумывает, Вам стоит написать программу. Винни-Пух считает, что ритм есть,
# если число слогов (т.е. число гласных букв) в каждой фразе стихотворения 
# одинаковое. Фраза может состоять из одного слова, если во фразе несколько слов, 
# то они разделяются дефисами. Фразы отделяются друг от друга пробелами.
# Написать функцию, которая принимает строку текста и проверяет ее ритм (по Винни-Пуху)
# Если ритм есть, функция возвращает True, иначе возвращает False

# Примеры/Тесты:
#     <function_name>("пара-ра-рам рам-пам-папам па-ра-па-дам") -> True
#     <function_name>("пара-ра-рам рам-пум-пупам па-ре-по-дам") -> True
#     <function_name>("пара-ра-рам рам-пуум-пупам па-ре-по-дам") -> False
#     <function_name>("Трам-пара-папам-парам-па-пам-пам-па Пум-пурум-пу-пурум-трам-пам-па") -> False
#     <function_name>("Пам-парам-пурум Пум-пурум-карам") -> True
# Примечание.

# Подумайте об эффективности алгоритма. Какие структуры данных будут более эффективны
# по скорости.
# Алгоритм должен работать так, чтобы не делать лишних проверок. Подумайте,
# возможно некоторые проверки не нужны.

# (*) Усложнение.
# Функция имеет параметр, который определяет, надо ли возвращать полную информацию 
# о кол-ве гласных букв в фразах. Эта информация возвращается в виде списка словарей.
# Каждый элемент списка(словарь) соответствует фразе.

# Примеры/Тесты:
#     <function_name>("пара-ра-рам рам-пам-папам па-ра-па-дам", False) -> True
#     <function_name>("пара-ра-рам рам-пам-папам па-ра-па-дам", True) -> (True, [{'а': 4}, {'а': 4}, {'а': 4}])
#     <function_name>("пара-ра-рам рам-пум-пупам па-ре-по-дам") -> (True, [{'а': 4}, {'а': 2, 'у': 2}, {'а': 2, 'е': 1, 'о': 1}])
#     <function_name>("пара-ра-рам рам-пуум-пупам па-ре-по-дам") -> (False, [{'а': 4}, {'а': 2, 'у': 3}])
#     <function_name>("Трам-пара-папам-парам-па-пам-пам-па Пум-пурум-пу-пурум-трам-пам-па") -> (False, [{'а': 11}, {'у': 6, 'а': 3}])
#     <function_name>("Пам-парам-пурум Пум-пурум-карам") -> (True, [{'а': 3, 'у': 2}, {'у': 3, 'а': 2}])

def Rythm(input_song_string: str, need_to_transcribe: bool)-> bool:
    rythm_status = False
    list_str1 = list()
    list_str1 = input_song_string.split()
    set_number_of_vowels = set()    
    for val in list_str1:
        number_of_vowels = val.count('а') + val.count('о') + val.count('у') + val.count('е')        
        set_number_of_vowels.add(number_of_vowels)        
    if len(set_number_of_vowels)==1:
        rythm_status = True
        if need_to_transcribe == True:
            list_a=Transcribe_Vowels(input_song_string)
            return (rythm_status, list_a)
        else:
            return rythm_status
    else:        
        if need_to_transcribe == True:
            list_a=Transcribe_Vowels(input_song_string)
            return (rythm_status, list_a)            
        else:
            return rythm_status

def Transcribe_Vowels(input_song_string: str) ->list:
    list_str = input_song_string.split()
    vowels_set = {'а', 'е', 'у', 'о'}
    vowels_dictionary = dict()
    list_of_dictionaries = list()
    for idx in range(len(list_str)):    
        for item in list_str[idx]:        
            if item in vowels_set and item not in vowels_dictionary:
                vowels_dictionary[item] = 1
            elif item in vowels_set and item in vowels_dictionary:
                vowels_dictionary[item]+=1    
        list_of_dictionaries.append(vowels_dictionary)        
        vowels_dictionary = dict()
    return list_of_dictionaries

str1 = "пара-ра-рам рам-пам-папам па-ра-па-дам"
print(Rythm(str1,False)) # True
str2 = "пара-ра-рам рам-пам-папам па-ра-па-дам"
print(Rythm(str2, True)) # (True, [{'а': 4}, {'а': 4}, {'а': 4}])
str3 = "пара-ра-рам рам-пум-пупам па-ре-по-дам"
print(Rythm(str3, True)) # (True, [{'а': 4}, {'а': 2, 'у': 2}, {'а': 2, 'е': 1, 'о': 1}])
str4 = "пара-ра-рам рам-пуум-пупам па-ре-по-дам"
print(Rythm(str4, True)) # (False, [{'а': 4}, {'а': 2, 'у': 3}])
str5 = "Трам-пара-папам-парам-па-пам-пам-па Пум-пурум-пу-пурум-трам-пам-па"
print(Rythm(str5, True)) # (False, [{'а': 11}, {'у': 6, 'а': 3}])
str6 = "Пам-парам-пурум Пум-пурум-карам"
print(Rythm(str6, True)) # (True, [{'а': 3, 'у': 2}, {'у': 3, 'а': 2}])