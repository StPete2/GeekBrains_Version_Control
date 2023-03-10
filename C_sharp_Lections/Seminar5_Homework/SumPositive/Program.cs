// Задачка вне зачета. Для того, чтобы спросить на занятии вопрос.

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
    foreach (int el in array)
    {
        quantity += el %2 == 0  ? el: 0;
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
Console.WriteLine(a);