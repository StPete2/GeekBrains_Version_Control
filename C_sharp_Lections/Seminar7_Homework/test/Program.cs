int [,] array = new int [,] 
{
    {7,4,3,2},
    {3,4,8,9},
    {1,0,5,4},    
};

double sum = 0;
double [] value = new double [array.GetLength(1)];
int index = 0;

for (int j = 0; j < array.GetLength(1); j++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = sum + array[i,j];
    }
    value[index] = Math.Round(sum/array.GetLength(0),1);
    index++;
    sum = 0;
}
Console.WriteLine(String.Join("; ", value));