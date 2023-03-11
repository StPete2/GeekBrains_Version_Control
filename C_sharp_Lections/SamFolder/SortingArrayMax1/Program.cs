//Сортировка массива на первое место минимальное число
int[] array = {8,6,3,2,1,5,4,7,1,10};
void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
PrintArray(array);

for (int i = 0; i < array.Length - 1; i++)
{
    int maxPosition = i;
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] > array [maxPosition])
        {
            maxPosition = j;
        }
    }
    int temp = array[i];
    array[i] = array[maxPosition];
    array[maxPosition] = temp;
}
PrintArray(array);
