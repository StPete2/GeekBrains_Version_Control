// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

int Prompt()
{
    Console.WriteLine("Введите количество элементов массива");
    return Convert.ToInt32(Console.ReadLine());
}

int size = Prompt();

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    return array;
}

int[] newarray = GetArray(size);
Console.WriteLine(string.Join(" ", newarray));

int [] CopyArray(int [] array, int size)
{
    int [] copiedArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        copiedArray[i] = array[i];
        //copiedArray[i] = array[size - 1 - i];
    }
    return copiedArray;
}
Console.WriteLine(String.Join(" ", CopyArray(newarray, size)));