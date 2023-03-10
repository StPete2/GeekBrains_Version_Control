int [] GetArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    return array;
}
int [] newArray = GetArray();

int [] ChangeSign(int []array, int size)
{
    int [] modArray = new int [size];
    for (int i = 0; i < array.Length; i++)
    {
        modArray[i] = array[i]*-1;
    }
    return modArray;
}
Console.WriteLine(String.Join(" ", newArray));
int [] changedArray = ChangeSign(newArray, 8);
Console.WriteLine(String.Join(" ", changedArray));