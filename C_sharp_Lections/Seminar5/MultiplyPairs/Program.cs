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
        array[i] = new Random().Next(-10,11);
    }
    return array;
}
int [] array = GetArray(sizeArray);

int [] MultiplyPairs(int [] array)
{
    int sizeMultArray = sizeArray/2;
    if (sizeArray%2 !=0)
    {
        sizeMultArray = sizeArray/2 + 1;
    }
    int [] multArray = new int [sizeMultArray];
    for (int i = 0; i < sizeArray - 1 - i; i++)
    {
        multArray[i] = array[i]*array[sizeArray -1 - i];
    }
    if (sizeArray%2 != 0)
    {
        multArray[sizeMultArray-1] = array[sizeArray/2];
    }
    return multArray;
}
Console.WriteLine(String.Join(" ", array));
Console.WriteLine(String.Join(" ", MultiplyPairs(array)));