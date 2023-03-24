// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int [,] matrixA = {{2,4},{3,2}};
int [,] matrixB = {{3,4},{3,3}};
int [,] matrixC = new int [matrixA.GetLength(0), matrixB.GetLength(1)];
matrixC[0,0] = matrixA[0,0]*matrixB[0,0] + matrixA[0,1]*matrixB[1,0];
matrixC[0,1] = matrixA[0,0]*matrixB[0,1] + matrixA[0,1]*matrixB[1,1];
matrixC[1,0] = matrixA[1,0]*matrixB[0,0] + matrixA[1,1]*matrixB[1,0];
matrixC[1,1] = matrixA[1,0]*matrixB[0,1] + matrixA[1,1]*matrixB[1,1];
for (int i = 0; i < matrixC.GetLength(0); i++)
{
    for (int j = 0; j < matrixC.GetLength(1); j++)
    {
        Console.Write(matrixC[i,j]+ "\t");
    }
    Console.WriteLine();
}
