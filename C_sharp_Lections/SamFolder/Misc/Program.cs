﻿bool IsEven(int value)
{
    return value%2 ==0;
}
int Prompt ()
{
    Console.WriteLine("Введите число для проверки деления на 2");
    return Convert.ToInt32(Console.ReadLine());
}
int a = Prompt();
bool result = IsEven(a);
Console.WriteLine(result);

Console.WriteLine(a.GetType().Name);