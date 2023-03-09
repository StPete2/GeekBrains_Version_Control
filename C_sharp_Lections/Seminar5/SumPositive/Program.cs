int [] GetArray(int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9,10);
    }
    return array;
}   

int InputNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int sizeArray = InputNumber("Введите размер массива");
int [] newArray = GetArray(sizeArray);

int SumNegative(int [] array)
{
    int sum = 0;
    foreach (int el in array)
    {
        sum += el < 0 ? el:0;
    }
    return sum;
}
int SumPositive(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

Console.WriteLine(String.Join(" ", newArray));
Console.WriteLine(SumNegative(newArray));
Console.WriteLine(SumPositive(newArray));