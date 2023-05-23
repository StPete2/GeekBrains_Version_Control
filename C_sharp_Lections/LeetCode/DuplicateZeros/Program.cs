void DuplicateZeros(int[] arr)
{
    int zeroCounter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == 0)
        {
            zeroCounter++;
        }
    }

    int modifiedArraySize = arr.Length + zeroCounter;
    int[] modifiedArray = new int[modifiedArraySize];

    // if (arr[arr.Length - 1] == 0)
    // {
    //     modifiedArray[modifiedArraySize -1]=0;
    //     modifiedArray[modifiedArraySize -2]=0;
    // }

    int valueCounter = 1;
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        if (arr[i] == 0)
        {
            modifiedArray[arr.Length + zeroCounter - valueCounter] = arr[i];
            zeroCounter--;
            modifiedArray[arr.Length + zeroCounter - valueCounter] = arr[i];            
        }        
        else
        {
            modifiedArray[arr.Length + zeroCounter - valueCounter] = arr[i];
            // Console.WriteLine($"{arr.Length+zeroCounter-valueCounter}, {zeroCounter}, {i}");
        }
        valueCounter++;
    }
    for (int i = arr.Length-1; i >=0; i--)
    {
        arr[i] = modifiedArray[i];
    }
    Console.WriteLine("ModifiedArray:");
    Console.WriteLine(String.Join(", ", modifiedArray));
}
int []initialArray = new int [] {1,0,2,3,0,4,5,0};
int[]initialArray2 = new int []{1,2,3};
Console.WriteLine("InitialArray:");
Console.WriteLine(String.Join(", ", initialArray2));
DuplicateZeros(initialArray2);
Console.WriteLine("Initial Array after modifications");
Console.WriteLine(String.Join(", ", initialArray2));