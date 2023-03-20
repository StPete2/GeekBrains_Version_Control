// Задача 53: Задайте двумерный массив. Напишите программу, которая 
// поменяет местами первую и последнюю строку массива.

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] CreateOutputCopyArray(int m, int n)
{
    int [,] array = new int [m,n];
    int [,] newArray = new int [m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,11);
            newArray[i,j] = array [i,j];
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    return newArray;
}
int m = Prompt("Введите количество строк");
int n = Prompt("Введите количество столбцов");

Console.WriteLine();
int [,] array = CreateOutputCopyArray(m,n);
Console.WriteLine();

int i=0;
int temp;
for (int j = 0; j < array.GetLength(1); j++)
{
    temp = array[i,j];
    array[i,j] = array[i+m-1,j];
    array[i+m-1,j] = temp;
}
for (i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine();
}
