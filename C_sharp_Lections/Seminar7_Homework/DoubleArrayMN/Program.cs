// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

double [,] CreateFillPrintArray(int m, int n)
{
    double [,] array = new double [m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-100,101) + Math.Round(new Random().NextDouble(),2);
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}
int m = Prompt("Введите количество строк");
int n = Prompt("Введите количество столбцов");
CreateFillPrintArray(m,n);