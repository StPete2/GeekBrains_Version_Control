# №8.1[49]. Создать телефонный справочник с возможностью импорта и экспорта данных в
# формате .csv
# Информация о человеке:
#     Фамилия, Имя, Телефон, Описание
# Корректность и уникальность данных не обязательны.
# Функционал программы
# 1) телефонный справочник хранится в памяти в процессе выполнения кода. 
#     Выберите наиболее удобную структуру данных для хранения справочника.
# 2) CRUD: Create, Read, Update, Delete
#     Create: Создание новой записи в справочнике: ввод всех полей новой записи, 
#             занесение ее в справочник.
#     Read: он же Select. Выбор записей, удовлетворяющих заданном фильтру: по первой
#             части фамилии человека. Берем первое совпадение по фамилии.
#     Update: Изменение полей выбранной записи. Выбор записи как и в Read, 
#             заполнение новыми значениями.
#     Delete: Удаление записи из справочника. Выбор - как в Read.
# 3) экспорт данных в текстовый файл формата csv
# 4) импорт данных из текстового файла формата csv

# Используйте функции для реализации значимых действий в программе
# Усложнение.
# - Сделать тесты для функций
# - Разделить на model-view-controller

# user=["ferstname","secondname","phone","discription"]
# dictionary = {1:["ferstname","secondname","phone","discription"],2:["ferstname","secondname","phone","discription"]}

def Input_Users()->list:
    user=list()
    user.append(input("Input first name "))
    user.append(input("Input second name "))
    user.append(input("Input phone "))
    user.append(input("Input discription "))
    
    return user
# print(Input_Users())
key_count =0
phone_dir = dict()
def create( phone_dir_local: dict, idc: int,  user:list)->dict:
    idc += 1
    phone_dir_local[idc] = user
    return phone_dir_local, idc

# user1 = ["second_name1","first_name1","phone1","discription1"]
# user2 = ["second_name2","first_name2","phone2","discription2"]

# phone_dir, key_count=create(phone_dir,key_count,user1)
# phone_dir, key_count=create(phone_dir,key_count,user2)
# print(phone_dir)

def menu ():
    print("Введите 1, если хотите ввести пользователя ")
    print("Введите 2, если хотите распечатать справочник ")
    key_count =0
    phone_dir = dict()
    while True:
        num = int(input("Выберите операцию "))
        if num == 0:
            break
        if num ==1:
            user = Input_Users()
            phone_dir, key_count = create(phone_dir,key_count,user)
        if num == 2:
            print (phone_dir)
menu ()
# Вывод записи на экран.
# Delete
# Update
# strip, split (делиметр) что-то надо будет сделать с id
# Каждой новой записи при импорте надо дать новый id. Increment idc++
