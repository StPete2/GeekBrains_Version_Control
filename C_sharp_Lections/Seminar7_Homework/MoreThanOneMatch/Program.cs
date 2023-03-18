int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int find = Prompt("Введите искомое значение в интервале от -10 до 10");
int count = 0;

int [,] CreateFillOutputCopyArray(int m, int n, int find, ref int count)
{
    int [,] array = new int [m,n];
    int [,] newArray = new int [m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-10,11);
            newArray[i,j] = array[i,j];
            if (array[i,j] == find)
            {
               count++;
            }
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    return newArray;
}

int m = Prompt("Введите количество строк");
int n = Prompt("Введите количество столбцов");

int [,] newArray = CreateFillOutputCopyArray(m,n,find,ref count);

int [,] MoreThanOneMatchIndexes(int [,] array, int find, int count)
{
    Console.WriteLine();
    Console.Write($"Искомый элемент {find} встречается в массиве произвольных чисел");
    Console.Write($" {count} раз и имеет следующие индексы: ");
    Console.WriteLine();
    int[,] coordinatesArray = new int[count, 2];
    count = 0;
    int secondIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == find)
            {
                coordinatesArray[count, secondIndex] = i;
                coordinatesArray[count, secondIndex + 1] = j;
                Console.Write($"{coordinatesArray[count, secondIndex]}, {coordinatesArray[count, secondIndex + 1]}");
                Console.WriteLine();
                count++;
            }
        }
    }
    return coordinatesArray;
}
int [,] coordinates = MoreThanOneMatchIndexes(newArray,find,count);