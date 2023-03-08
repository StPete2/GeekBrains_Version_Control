// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] FillArray(int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1,100);        
    }
    return array;
}
int InputNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
string text = "Введите размер массива";
int a = InputNumber(text);
int[] newArray = FillArray(a);
Console.WriteLine($"[{String.Join(" ", newArray)}]");