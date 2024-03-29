﻿// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] CreateFillArray(int m, int n)
{
    int [,] array = new int [m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,11);
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}
int m = Prompt("Введите количество строк");
int n = Prompt("Введите количество столбцов");

Console.WriteLine();
int [,] array = CreateFillArray(m,n);
Console.WriteLine();

int [] sumOfLines(int [,]array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] = array[i, j] + sum[i];
        }
    }
    return sum;
}
int []sum = sumOfLines(array);
Console.WriteLine("Построчная сумма элементов массива:");
Console.WriteLine(String.Join(" ", sum));
Console.WriteLine();

int minIndex = 0;
int MinimumSum(int []sum, ref int minIndex)
{
    int min = sum[0];    
    // int count = 0;
    for (int i = 1; i < sum.Length; i++)
    {
        if (sum[i] < min)
        {
            min = sum[i];
            minIndex = i;
        }
    }
    return min;
}

// for (int i = 0; i < sum.Length; i++)
// {
//     if (sum[i] == min)
//     {
//         count++;
//     }
// }
int min = MinimumSum(sum, ref minIndex);
Console.WriteLine($"Минимальная сумма элементов, равная {min}, содержится в строке с индексом {minIndex}");
// Console.WriteLine($"Всего минимальная сумма элементов встречается в количестве строк: {count}");
