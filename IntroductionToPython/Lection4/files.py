# a - append - добавление данных
# r - read - открытие для чтения данных
# w - write - запись в файл (перезапись всего файла)
# w+ - открытие для записи и чтение из файла
# r+ - открывать для чтения и дописывать
colors = ['red', 'green', 'blue']
data = open('file.txt', 'a')
data.writelines(colors)
data.close()

with open('file.txt', 'w') as data:
    data.write('line 1\n')
    data.write('line 2\n') # файл автоматически закрывается
print('etwas')

path = 'file.txt'
data = open(path, 'r')
for line in data:
    print(line)
data.close()