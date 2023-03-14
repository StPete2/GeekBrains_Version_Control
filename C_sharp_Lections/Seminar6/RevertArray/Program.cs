int InputNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int a = InputNumber("Введите размер массива");

double [] FillArray(int size)
{
    double [] array = new double [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round((new Random().Next(0,11) + new Random().NextDouble()), 2);
    }
    return array;
}
double [] newArray = FillArray(a);
Console.WriteLine(String.Join("; ", newArray));

// void PrintArray(double array, int size)
// {
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }    
// }

double [] RevertArray(double [] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        double temp = array[i];
        array[i] = array[array.Length - 1 -i];        
        array[array.Length - 1 - i] = temp;
    }
    return array;
}
double [] revertedArray = RevertArray(newArray);
Console.WriteLine(String.Join("; ", revertedArray));