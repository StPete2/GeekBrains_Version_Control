// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int InputNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int sizeArray = InputNumber("Введите размер массива");

int [] GetArray(int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10,100);
    }
    return array;
}
int [] array = GetArray(sizeArray);

int SumNegativeIndex(int [] array)
{
    int sum = 0;
    //int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 != 0)
        {
            sum = sum + array[i];
            //count = count + 1;
        }
    }
    return sum;
}
void PrintArray(int [] array)
{
    foreach (int el in array)
    {
        Console.Write($"{el} ");
    }
    Console.WriteLine();
}

int a = SumNegativeIndex(array);
PrintArray(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна: {a}.");