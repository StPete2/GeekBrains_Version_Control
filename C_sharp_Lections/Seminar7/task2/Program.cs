// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса
// чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] CreateOutputArray(int m, int n)
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

//CreateOutputArray(m,n);
Console.WriteLine();
int [,] array = CreateOutputArray(m,n);

int [,] MultiplyEvenIndex (int [,] array)
{
    // int [,] newArray = new int [m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i %2 ==0 && j %2 == 0)
            {
                array[i,j] = array[i,j]*array[i,j];
                // Console.Write(array[i,j] + "\t");
            }
            // else 
            // {   
            //     array[i,j] = array[i,j];
            Console.Write(array[i,j] + "\t");
            // }
        }
        Console.WriteLine();
    }
    return array;
}
Console.WriteLine();
int [,] newArray = MultiplyEvenIndex(array);
