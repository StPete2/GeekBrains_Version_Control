// Задача 55: Задайте двумерный массив. Напишите программу, которая 
// заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.
int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] CreateOutputCopyArray(int m, int n)
{
    int [,] array = new int [m,n];
    // int [,] newArray = new int [m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,11);
            //newArray[i,j] = array [i,j];
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}
int m = Prompt("Введите количество строк");
int n = Prompt("Введите количество столбцов");

Console.WriteLine();
int [,] array = CreateOutputCopyArray(m,n);
Console.WriteLine();

int [,] InterpolateArray(int [,]array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0 + i; j < array.GetLength(1); j++)
        {
            if (i != j)
            {
                temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
        }
    }    
    return array;
}

//int [,] changedArray = InterpolateArray(array);

void PrintArray(int [,]array)
{
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

bool CheckArray(int [,]array)
{
    if (m == n)
    {
        return true;
    }
    else
    {
        Console.WriteLine("Количество строк не равно количеству столбцов");
        return false;
    }
}

if (CheckArray(array))
{
    int [,] changedArray = InterpolateArray(array);  
    PrintArray(changedArray);
}