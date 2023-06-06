# №4.1[25]. Напишите программу, которая принимает на вход строку, и отслеживает, 
# сколько раз каждый символ уже встречался.
# Количество повторов добавляется к символам с помощью постфикса формата _n.

# Примеры/Тесты:
#     Input: a a a b c a a d c d d
#     Output: a a_1 a_2 b c a_3 a_4 d c_1 d_1 d_2

#     Input: a b c d a a a a a a a
#     Output: a b c d a_1 a_2 a_3 a_4 a_5 a_6 a_7

# Строку не обязательно вводить с клавиатуры

# *** Решение №1 ***
# string_input = "a a a b c a a d c d d" # почему не работает со строкой?
# string_input = string_input.replace(' ', '')
# result_string = ""
# for indx, val in enumerate(string_input):
#     number_of_appearance = string_input[0:indx].count(val)
#     if number_of_appearance > 0:
#         result_string = result_string + str(val) +"_" + str(indx) + " "
#     else:
#         result_string = result_string + val + " "
# print(result_string)

# *** Решение № 2 ***
# string_input2 = "a a a b c a a d c d d"
# # string_input2 = string_input2.strip() # - почему не работает здесь?
# string_input2 = string_input2.replace(' ', '')
# result = []
# for indx, val in enumerate(string_input2):
#     n = string_input2[0:indx].count(val)
#     result.append(f"{val}_{n}" if n > 0 else val)
#     # if n > 0:
#     #     result.append(f"{val}_{n}")
#     # else:
#     #     result.append(val)
# print(result)
# print(" ".join(result))

# *** Решение № 3 ***
string_input3 = "a a a b c a a d c d d"
result = []
string_input3 = string_input3.replace(' ', '')
d = dict()
print(d)
for indx, val in enumerate(string_input3):
    if val in d.keys():
        d[val] += 1
        result.append(f"{val}_{d[val]}")
    else:
        d[val] = 0
        result.append(val)
print(result)
print(d)

# *** Решение № 4 ***
input_string = "a a a b c a a d c d d"
amount_of_letters = dict()
output_string = ""
for el in input_string:
    if el != " ":
        if el not in amount_of_letters:
            amount_of_letters[el] = 1
            output_string = output_string + el
        else:
            output_string = output_string + el + "_" + str(amount_of_letters[el])
            amount_of_letters[el] += 1
    else:
        output_string = output_string + el
print(output_string)