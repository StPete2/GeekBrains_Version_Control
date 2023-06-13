from os.path import join, abspath, relpath, dirname, exists
# удобное преобразование пути из относительного в абсолютный и наоборот.
from os import getcwd
print(getcwd())
main_dir = join(".")
print(main_dir)
print(abspath(main_dir))
filename = join(main_dir, "IntroductionToPython", "Seminar7", "data1.txt")
print(exists(filename))

# file - становится специальным объектом, к которому мы можем обращаться. После строчки ниже:

# file = open(filename, mode = 'rt', encoding="utf-8")
# for line in file:
#     print(line.strip())
# file.close()


# # Фамилия_1, Имя_1, Телефон_1, Описание_1
# # Фамилия_2, Имя_2, Телефон_2, Описание_2
# # Менеджер контекста

with open (filename, mode="rt", encoding="utf-8") as file:
    for line in file:
        print(line.replace("#", " ").strip())

print("THE END")
