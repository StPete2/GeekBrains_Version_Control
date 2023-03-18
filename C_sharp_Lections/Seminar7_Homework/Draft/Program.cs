int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] CreateOutputArray(int m, int n)
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

//CreateOutputArray(m,n);
Console.WriteLine();
int [,] array = CreateOutputArray(m,n);