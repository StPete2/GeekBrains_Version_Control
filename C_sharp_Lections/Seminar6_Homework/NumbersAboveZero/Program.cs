// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите число или числа через пробел");
string [] words = Console.ReadLine().Split(" ");
int size = 0;
foreach (string el in words)
{
    size ++;
}
int [] numbers = new int [size];
int i = 0;
int count = 0;
foreach (string el in words)
{
    numbers[i] = Convert.ToInt32(el);
    if (numbers[i]>0)
    {
        count++;
    }
    i++;
}   
    
Console.WriteLine(String.Join(" ", numbers));
Console.WriteLine("Количество чисел больше нуля, которые ввел пользователь: " + count + ".");
