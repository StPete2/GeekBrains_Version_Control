import os.path as path1
from os import getcwd
from os.path import abspath
MAIN_DIR = path1.abspath(path1.dirname(__file__))
print(f"path: {MAIN_DIR}") #C:\Users\Алексей\Documents\Программирование Geek\Git_Education\IntroductionToPython> 
file_name = path1.join(MAIN_DIR, "export.csv")
file_name2 = path1.join(MAIN_DIR, "import.csv")
print(file_name)
phone_dir = {1:[1,2,3,4]}
idc = 2
# with open(file_name, mode='w', encoding='utf-8') as file:
#     file.write(phone_dir)
with open(file_name2, mode='rt', encoding='utf-8') as file:
    for line in file:
        _, family_name, name, phone, discription = line.strip().split('#')
        phone_dir[idc] = [family_name, name, phone, discription]
        print(phone_dir)
        idc+=1

print(phone_dir)