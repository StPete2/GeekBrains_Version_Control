void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index]= new Random().Next(1,10);
        index = index + 1;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position = position + 1;
    }
}
int IndexF(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //если элемента нет, то он выдаст значение -1!!! Круто!!!
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index = index + 1;
    }
    return position;
}

int[] array = new int[10];
int find = new Random().Next(0,10);
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Ищем индекс элемента со значением " + find);
int pos = IndexF(array, find);
Console.WriteLine(pos);