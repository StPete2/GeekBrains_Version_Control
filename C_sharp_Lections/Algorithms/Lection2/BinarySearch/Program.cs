int BinarySeach(int[] array, int value, int min, int max)
{
    int midpoint;
    if (max < min)
    {
        return -1;
    }
    else
    {
        midpoint = (max - min) / 2 + min;
    }    
    if (array[midpoint]<value)
    {
        return BinarySeach(array, value, midpoint+1, max);
    }
    else
    {
        if (array[midpoint]> value)
        {
            return BinarySeach(array, value, min, midpoint - 1);
        }
        else
        {
            return midpoint;
        }
    }
}

int [] array = new int [] {0,1,2,3,4,5,6,7,8,9,10,11};
int indexOfElement = BinarySeach(array, 21, 0, array.Length-1);
Console.WriteLine(indexOfElement);