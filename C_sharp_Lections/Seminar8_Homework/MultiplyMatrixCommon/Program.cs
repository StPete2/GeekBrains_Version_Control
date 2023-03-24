int [,] matrixA = {{2,4},{3,2}};
int [,] matrixB = {{3,4},{3,3}};
if (matrixA.GetLength(1) == matrixB.GetLength(0))
{
    Console.WriteLine("Умножение матриц возможно");
}
else
{
    Console.WriteLine("Перемножение матриц невозможно");
}

int [,] matrixC = new int [matrixA.GetLength(0), matrixB.GetLength(1)];
for (int i = 0; i < matrixC.GetLength(0); i++)
{
    for (int j = 0; j < matrixC.GetLength(1); j++)
    {
        int sum = 0;
        for (int k = 0; k < matrixA.GetLength(1); k++)
        {
            sum = sum + matrixA[i,k] * matrixB[k,j];
        }
        matrixC[i,j] = sum;
    }
}

void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

PrintMatrix(matrixC);