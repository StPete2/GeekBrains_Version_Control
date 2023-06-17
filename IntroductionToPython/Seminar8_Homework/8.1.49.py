# 8.1[49]: Создать телефонный справочник с возможностью импорта и экспорта данных 
# в формате csv. Доделать задание вебинара и реализовать Update, Delete
# Информация о человеке: Фамилия, Имя, Телефон, Описание

# Корректность и уникальность данных не обязательны.

# Функционал программы
# 1) телефонный справочник хранится в памяти в процессе выполнения кода.
# Выберите наиболее удобную структуру данных для хранения справочника.
# 2) CRUD: Create, Read, Update, Delete

# Create: Создание новой записи в справочнике: ввод всех полей новой записи, 
# занесение ее в справочник.

# Read: он же Select. Выбор записей, удовлетворяющих заданном фильтру: по первой
# части фамилии человека. Берем первое совпадение по фамилии.

# Update: Изменение полей выбранной записи. Выбор записи как и в Read, заполнение
#  новыми значениями.

# Delete: Удаление записи из справочника. Выбор - как в Read.

# 3) экспорт данных в текстовый файл формата csv
# 4) импорт данных из текстового файла формата csv
# Используйте функции для реализации значимых действий в программе
# (*) Усложнение.
# Сделать тесты для функций
# Разделить на model-view-controller

def Menu():
    print("Введите 1, если хотите ввести нового пользователя")
    print("Введите 2, если хотите найти и вывести информацию о пользователе на экран")
    print("Введите 3, если хотите изменить информацию о пользователе")
    print("Введите 4, если хотите удалить запись о пользователе")
    print("Введите 5, если хотите распечатать справочник")
    print("Введите 6, если хотите экспортировать справочник в файл формата .csv")
    print("Введите 7, если хотите импортировать данные в справочник из файла формата .csv")
    print("Нажмите 0 для выхода из меню и завершения работы программы")
    print()    
    key_count = 0
    phone_dir = dict()
    while True:
        num = int(input("Введите Ваш выбор: "))
        if num == 0:
            break
        if num == 1:
            user = Input_User()
            phone_dir, key_count = Create_User(phone_dir,key_count,user)        
        
        if num == 5:
            print(phone_dir)
        if num == 6:
            Export_Data(str(phone_dir))
        if num == 7:
            phone_dir, key_count = Import_Data(phone_dir,key_count)


#1
def Input_User()-> list:
    user = []
    user.append(input("Введите фамилию пользователя: "))
    user.append(input("Введите имя пользователя: "))
    user.append(input("Введите телефон пользователя: "))
    user.append(input("Введите описание: "))
    return user

#1
def Create_User(phone_dir_local: dict, key_count: int, user:list)->dict:
    key_count +=1
    phone_dir_local [key_count] = user
    return phone_dir_local, key_count

#5
# печатается из меню

#6
def Export_Data(phone_dir_local: dict):
    import os.path as path1
    from os.path import abspath
    MAIN_DIR = path1.abspath(path1.dirname(__file__))   
    file_name = path1.join(MAIN_DIR, "export.csv")
    with open(file_name, mode='w', encoding='utf-8') as file:
        file.write(phone_dir_local)

#7
def Import_Data(phone_dir_local: dict, key_count: int)-> dict:
    import os.path as path1
    from os.path import abspath
    MAIN_DIR = path1.abspath(path1.dirname(__file__))
    file_name2 = path1.join(MAIN_DIR, "import.csv")
    with open(file_name2, mode='rt', encoding='utf-8') as file:        
        for line in file:
            key_count+=1
            _, family_name, name, phone, discription = line.strip().split('#')
            phone_dir_local[key_count] = [family_name, name, phone, discription]            
    return phone_dir_local, key_count

Menu()
