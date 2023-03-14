void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index]= new Random().Next(1,20);
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
int[] array = new int [10]; /*так объявляется массив */ /* и это круто! */
FillArray(array);
PrintArray(array);
Console.WriteLine();
// FillArray(array);
// PrintArray(array); // все работает. Работает дважды, каждый раз по-новому.

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

int[] array2 = new int[20];
int find = new Random().Next(0,20);
FillArray(array2);
PrintArray(array2);
Console.WriteLine();
Console.WriteLine("Ищем индекс элемента со значением " + find);
int pos = IndexF(array2, find);
Console.WriteLine(pos);