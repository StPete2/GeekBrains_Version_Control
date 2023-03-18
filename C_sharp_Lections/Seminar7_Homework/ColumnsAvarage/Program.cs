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


double [] ColumnsAvarage(int [,]array)
{
    double [] value = new double [array.GetLength(1)];
    double sum = 0;
    int index = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        value[index] = Math.Round(sum / array.GetLength(0), 1);
        index++;
        sum = 0;
    }
    return value;
}
double [] avarageValueArray = ColumnsAvarage(array);
Console.WriteLine("Среднее арифметическое каждого столбца равно:");
Console.WriteLine(String.Join("\t", avarageValueArray));