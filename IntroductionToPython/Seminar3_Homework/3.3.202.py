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
costEng = {1: {'A', 'E', 'I', 'O', 'U', 'L', 'N', 'S', 'T', 'R'},
2: {'D', 'G'}, 3: {'B', 'C', 'M', 'P'}, 4: {'F', 'H', 'V', 'W', 'Y'}, 
5: {'K'}, 8: {'J', 'X'}, 10: {'Q', 'Z'}}
costRus = {1: {'А', 'В', 'Е', 'И', 'Н', 'О', 'Р', 'С', 'Т'}, 
2: {'Д', 'К', 'Л', 'М', 'П', 'У'}, 3: {'Б', 'Г', 'Ё', 'Ь', 'Я'}, 
4: {'Й', 'Ы'}, 5: {'Ж', 'З', 'Х', 'Ц', 'Ч'}, 8: {'Ш', 'Э', 'Ю'}, 
10: {'Ф', 'Щ', 'Ъ'}}
wordEng = str(input("Введите слово на английском языке: ")).upper()
wordRus = str(input("Введите слово на русском языке: ")).upper()
wordCostEng = 0
wordCostRus = 0
for char in wordEng:
    for cost, chars_set in costEng.items():
        if char in chars_set:
            wordCostEng += cost
            break
for char in wordRus:
    for cost, chars_set in costRus.items():
        if char in chars_set:
            wordCostRus += cost
            break
print("Сумма очков в английском слове равна: ", wordCostEng)
print("Сумма очков в русском слове равна: ", wordCostRus)

# это решение подсмотрел на лекции, понравилось.
# мое решение, наверно, длинее будет. Которое в файле 3.3.20.py
# Сергей, скажите, пожалуйста, а как бы Вы решили эту задачу?
# И еще один вопрос: а мое решение как-то можно сократить?
# С уважением,
# Алексей.