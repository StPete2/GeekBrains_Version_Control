// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

int Prompt()
{
    Console.WriteLine("Введите количество элементов массива");
    return Convert.ToInt32(Console.ReadLine());
}

int size = Prompt();

int[] GetArray()
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    return array;
}

int[] newarray = GetArray();
Console.WriteLine(string.Join(" ", newarray));

int [] CopyArray(int array)
{
    int [array] = new int [size]
}
