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
string text2 = "Введите размер массива";
int size2 = InputNumber(text2);
int [] newArray = GetArray(size2);
void ChangeNumber(int[] array, int sizeArray)
{
    for (int i = 0; i < sizeArray; i++)
    {
        array[i] = array[i]*(-1);
    }    
}
Console.WriteLine(String.Join(" ", newArray));
ChangeNumber(newArray, size2);
Console.WriteLine(String.Join(" ", newArray));
