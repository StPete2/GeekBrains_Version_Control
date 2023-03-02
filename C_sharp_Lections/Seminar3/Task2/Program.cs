// Задача №22. Работа в группах
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.
//Math.Pow()
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"{number} -> ");
for (int index = 1; index <= number; index++)
{
    Console.Write($"{index*index} ");
}