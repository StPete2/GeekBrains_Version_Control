# 3.3[20]: В настольной игре Скрабл (Scrabble) каждая буква имеет определенную 
# ценность. В случае с английским алфавитом очки распределяются так:
# A, E, I, O, U, L, N, S, T, R – 1 очко;
# D, G – 2 очка;
# B, C, M, P – 3 очка;
# F, H, V, W, Y – 4 очка;
# K – 5 очков;
# J, X – 8 очков;
# Q, Z – 10 очков.

# А русские буквы оцениваются так:
# А, В, Е, И, Н, О, Р, С, Т – 1 очко;
# Д, К, Л, М, П, У – 2 очка;
# Б, Г, Ё, Ь, Я – 3 очка;
# Й, Ы – 4 очка;
# Ж, З, Х, Ц, Ч – 5 очков;
# Ш, Э, Ю – 8 очков;
# Ф, Щ, Ъ – 10 очков.

# Напишите программу, которая вычисляет стоимость введенного пользователем слова. 
# Будем считать, что на вход подается только одно слово, которое содержит либо
# только английские, либо только русские буквы и заранее известно какой алфавит надо
# использовать.

#     Примеры/Тесты:
#     Input:   ноутбук
#     Output:  12
    
#     Input:   notebook
#     Output:  14

# ```(*)``` **Примечание.**
# Подумайте о том какие структуры данных здесь наиболее удобно использовать, 
# чтобы просто проверять в какую группу попадает буква, а также просто накапливать
# сумму очков.
listEng = [['A', 'E', 'I', 'O', 'U', 'L', 'N', 'S', 'T', 'R'],
['D', 'G'], ['B', 'C', 'M', 'P'], ['F', 'H', 'V', 'W', 'Y'], ['K'], ['J', 'X'],
['Q', 'Z']]
listRus = [['А', 'В', 'Е', 'И', 'Н', 'О', 'Р', 'С', 'Т'], 
['Д', 'К', 'Л', 'М', 'П', 'У'], ['Б', 'Г', 'Ё', 'Ь', 'Я'], ['Й', 'Ы'],
['Ж', 'З', 'Х', 'Ц', 'Ч'], ['Ш', 'Э', 'Ю'], ['Ф', 'Щ', 'Ъ']]
wordEng = str(input("Введите слово на английском языке: ")).upper()
wordRus = str(input("Введите слово на русском языке: ")).upper()
wordWeightEng = 0
wordWeightRus = 0
for i in wordEng:
    if i in listEng[0]:
        wordWeightEng += 1
    elif i in listEng[1]:
        wordWeightEng += 2
    elif i in listEng[2]:
        wordWeightEng += 3 
    elif i in listEng[3]:
        wordWeightEng += 4
    elif i in listEng[4]:
        wordWeightEng += 5
    elif i in listEng[5]:
        wordWeightEng += 8
    elif i in listEng[6]:
        wordWeightEng += 10
for i in wordRus:
    if i in listRus[0]:
        wordWeightRus += 1
    elif i in listRus[1]:
        wordWeightRus += 2
    elif i in listRus[2]:
        wordWeightRus += 3 
    elif i in listRus[3]:
        wordWeightRus += 4
    elif i in listRus[4]:
        wordWeightRus += 5
    elif i in listRus[5]:
        wordWeightRus += 8
    elif i in listRus[6]:
        wordWeightRus += 10
print("Количество очков в английском слове = " + str(wordWeightEng))
print("Количество очков в русском слове = " + str(wordWeightRus))