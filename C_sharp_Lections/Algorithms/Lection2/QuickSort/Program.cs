void QuickSort(int [] array, int startPosition, int endPosition)
{
    int leftPosition = startPosition;
    int rightPosition = endPosition;
    int pivot = array[(startPosition + endPosition)/2];
    do
    {
        while (array[leftPosition] < pivot)
        {
            leftPosition++;
        }
        while (array[rightPosition] > pivot)
        {
            rightPosition--;
        }
        if (leftPosition<=rightPosition)
        {
            if (leftPosition < rightPosition)
            {
                int temp = array[leftPosition];
                array[leftPosition] = array[rightPosition];
                array[rightPosition] = temp;                
            }
            leftPosition++;
            rightPosition--;            
        }
    } while (leftPosition<=rightPosition);

    if (leftPosition<endPosition)
    {
        QuickSort(array, leftPosition, endPosition);
    }
    if (startPosition<rightPosition)
    {
        QuickSort(array, startPosition, rightPosition);
    }
}
int [] array = new int [] {2,10,15,20,3,1,0,15,45,100,0,29};
QuickSort(array,0,array.Length-1);
Console.WriteLine(String.Join(" ", array));