// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76
int InputNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int sizeArray = InputNumber("Введите размер массива");

double [] GetArray(int size)
{
    double [] array = new double [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0,100);
    }
    return array;
}
double [] array = GetArray(sizeArray);
Console.WriteLine(String.Join(" ", array));

double MinElement(double []array)
{
    int i = 0;
    double min = array[i];
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
double a = MinElement(array);

double MaxElement(double []array)
{
    int i = 0;
    double max = array[i];
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
double b = MaxElement(array);
double c = b - a;
Console.WriteLine("Разница между максимальным и минимальным значениями массива равняется " + c);
