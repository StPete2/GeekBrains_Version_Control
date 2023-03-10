// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
        array[i] = new Random().Next(100,1000);
    }
    return array;
}
int [] array = GetArray(sizeArray);

int PositiveQuantity(int [] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] %2 == 0)
        {
            quantity = quantity + 1;
        }
        // foreach (int el in array)
        // {
        //     el %2 ==0 ? quantity = quantity + 1 : quantity = quantity + 0;
        // }
    }
    return quantity;
}
void PrintArray(int [] array)
{
    foreach (int el in array)
    {
        Console.Write($"{el} ");
    }
    Console.WriteLine();
}
PrintArray(array);
int a = PositiveQuantity(array);
Console.WriteLine($"Количество положительных чисел равно: {a}.");