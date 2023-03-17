// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] CreateFillOutputArray(int m, int n)
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
int [,] array = CreateFillOutputArray(m,n);

int SumOfMainDiagonalIndexes(int [,] array)
{
    int sum = 0;
    for (int i = 0, j=0; i < array.GetLength(0) && j < array.GetLength(1); i++, j++)
    {
        sum = sum + array[i,j];
    }
    return sum;
}
Console.WriteLine();
Console.WriteLine($"Сумма индексов по главной диагонали равна: {SumOfMainDiagonalIndexes(array)}");