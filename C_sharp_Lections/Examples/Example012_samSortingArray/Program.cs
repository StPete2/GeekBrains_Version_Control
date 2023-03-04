//Сортировка массива
int[] array = {8,6,3,2,1,5,4,7};
int index = 0;
int minIndex = 0;
int temp = 0;
int size = 8;
int min = array[index];
int sortedIndex = 0;
for (sortedIndex = 0; sortedIndex < size; sortedIndex++)
{
    for (index = index + sortedIndex; index < size; index++)
    {
        //Console.Write(index);
        if (array[index] < min)
        {
            min = array[index];
            minIndex = index;
        }
    }
    //Console.WriteLine($"{array[index-1]}, {minIndex}, {min}");
    temp = array[index];  
    array[index] = array[minIndex];
    array[minIndex] = temp;
    //Console.WriteLine($"{array[index]}, {index}");
    //Console.WriteLine(sortedIndex);
}
Console.WriteLine(array[7]);
