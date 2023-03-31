// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший 
// элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int m = Prompt("Введите количество строк");
int n = Prompt("Введите количество столбцов");

int [,] CreateFillArray(int m, int n)
{
    int [,] matrix = new int [m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,10);            
        }
    }
    return matrix;
}

int [,] matrix = CreateFillArray(m,n);

void PrintArray(int [,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

PrintArray(matrix);

int [] IndexesOfMinElement(int [,]matrix)
{
    int [] indexesOfMinElement = {0,0};
    int min = matrix[0,0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < min)
            {
                min = matrix[i,j];
                indexesOfMinElement[0] = i;
                indexesOfMinElement[1] = j;
            }
        }
    }
    return indexesOfMinElement;
}
int [] indexesOfMinElement = IndexesOfMinElement(matrix);
Console.WriteLine(indexesOfMinElement[0] + ", " + indexesOfMinElement[1]);

int [,] NewMatrixWithoutLinesOfMinElement(int [,] matrix, int [] indexesOfMinElement)
{
    int [,] newMatrixWithoutLinesOfMinElement = new int [matrix.GetLength(0)-1,matrix.GetLength(1)-1];
    int k = 0;
    int l = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != indexesOfMinElement[0])
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != indexesOfMinElement[1])
                {
                    newMatrixWithoutLinesOfMinElement[k, l] = matrix[i, j];
                    l ++;
                }                
            }
            l = 0;
            k++;    
        }        
    }
    return newMatrixWithoutLinesOfMinElement;
}
int [,] newMatrixWithoutLinesOfMinElement = NewMatrixWithoutLinesOfMinElement(matrix, indexesOfMinElement);
PrintArray(newMatrixWithoutLinesOfMinElement);