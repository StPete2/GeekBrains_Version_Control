// Pascal triangle
int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int n = Prompt("Введите количество строк в треугольнике");
Console.WriteLine();

int [,] matrix = new int [n,n];
matrix[0,0]=1;
Console.WriteLine(matrix[0,0]);

for (int i = 1; i < n; i++)
{
    for (int j = 0; j <= i; j++)
    {
        if ( j==0 || i==j)
        {
            matrix [i,j] = 1;
        }
        else
        {
            matrix[i,j] = matrix[i-1,j] + matrix[i-1,j-1];
        }
        Console.Write(matrix[i,j]+ "\t");
    }
    Console.WriteLine();
}