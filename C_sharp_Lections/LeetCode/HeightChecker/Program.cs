int HeightChecker(int[] heights) 
{
    int [] doubleHeights = new int [heights.Length];
    for (int i = 0; i < heights.Length; i++)
    {
        doubleHeights[i] = heights[i];
    }    
    int temp;
    for (int i = 0; i < doubleHeights.Length-1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < doubleHeights.Length; j++)
        {
            if (doubleHeights[minPosition]>doubleHeights[j])
            {
                minPosition = j;
            }
        }
        temp = doubleHeights[i];
        doubleHeights[i] = doubleHeights[minPosition];
        doubleHeights[minPosition] = temp;
    }
    Console.WriteLine(String.Join(" ", doubleHeights));
    int numberOfIndices = 0;
    for (int i = 0; i < heights.Length; i++)
    {
        if (heights[i]!=doubleHeights[i])
        {
            numberOfIndices++;
        }
    }
    return numberOfIndices;
}
int [] heights = new int [] {1,1,4,2,1,3};
int k = HeightChecker(heights);
Console.WriteLine(k);