int [] array = {8,7,6,10,1,4,3,2,9,0,1};
Console.WriteLine(String.Join(" ", array));
int sortedSize = 0;
for (int j = 0; j < array.Length; j++)
{
    for (int i = 0; i < array.Length - 1 - sortedSize; i++)
    {
        if (array[i] > array [i+1])
        {
            int temp = array[i];
            array[i] = array[i+1];
            array[i+1] = temp;
        }
        Console.WriteLine(String.Join(" ", array));
    }
    sortedSize ++;    
}
Console.WriteLine(String.Join(" ", array));