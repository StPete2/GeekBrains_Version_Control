# ------ Цикл по словарю
my_dict = {1: "10", 2: "45", 4: "678", 1212: "98886"}

# Цикл по ключам словаря
for key in my_dict:
    # Здесь доступен ключ  key, и элемент как my_dict[key]
    print(key, my_dict[key])
# Точно такой же результта потому, что по умолчанию используется именно последовательность ключей
for key in my_dict.keys():
    print(key, my_dict[key])

# Цикл по значениям словаря.
for val in my_dict.values():
    # Здесь ключ недоступен только значение
    print(val)

# Цикл, когда нужен и ключ и значение элемента
for key, val in my_dict.items():
    print(key, val)
