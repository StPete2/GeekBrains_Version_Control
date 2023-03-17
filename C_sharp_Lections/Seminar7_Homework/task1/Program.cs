// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int find = Prompt("Введите искомое значение в интервале от -20 до 20");
int index0 = 0;
int index1 = 1;
int count = 0;

int [,] CreateFillOutputArray(int m, int n, int find, ref int count)
{
    int [,] array = new int [m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-20,21);
            if (array[i,j] == find)
            {
               index0 = i;
               index1 = j; 
               count = 1;
            }
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

int m = Prompt("Введите количество строк");
int n = Prompt("Введите количество столбцов");
CreateFillOutputArray(m,n,find,ref count);
if (count == 0)
{
    Console.WriteLine($"Искомый элемент {find} в массиве случайных чисел не найден");
}
else
{
    Console.WriteLine($"Искомый элемент {find} найден в массиве и находится под индексами ({index0}, {index1})");
}

