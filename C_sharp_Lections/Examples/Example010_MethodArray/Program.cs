int[] array = {1, 12, 31, 4, 15, 4, 17, 18};
int n = array.Length;
Console.WriteLine("Введите произвольное целое число");
int find = Convert.ToInt32(Console.ReadLine());
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine("Искомый элемент найден в массиве. Его индекс = " + index + ", его значение = " + find);
        break;
    }
    index = index + 1;
}