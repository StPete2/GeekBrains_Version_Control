// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int [,] matrix4x4 = new int [4,4];
int value = 1;
int i = 0;
int j = 0;
while (value <= matrix4x4.GetLength(0)*matrix4x4.GetLength(1))
{
    matrix4x4[i,j] = value;
    value++;
    if (i <= j + 1 && i+j < matrix4x4.GetLength(1)-1)
    {
        j++;
    }
    else if (i<j && i + j >= matrix4x4.GetLength(0)-1)
    {
        i++;
    }
    else if (i>=j && i + j > matrix4x4.GetLength(1)-1)
    {
        j--;
    }
    else
    {
        i--;
    }
}

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
PrintArray(matrix4x4);