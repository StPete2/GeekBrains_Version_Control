// Задача 32: Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int [] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10, 11);
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
void ChangeSign(int[] array, int size)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = array[i]*-1;
    }        
}
// int [] ChangeSign(int []array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = array[i]*-1;
//     }
//     return array;
// }
Console.WriteLine(String.Join(" ", newArray));
ChangeSign(newArray, sizeArray);
Console.WriteLine(String.Join(" ", newArray));