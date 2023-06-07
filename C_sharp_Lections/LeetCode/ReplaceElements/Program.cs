int[] ReplaceElements(int[] arr) 
{
    if (arr.Length == 0)
    {
        return arr;
    }
    else if (arr.Length == 1)
    {
        int i = 0;
        arr[i] = -1;
        return arr;
    }    
    else
    {
        int rightMax = arr[arr.Length-1];
        if (arr[arr.Length-2] > arr[arr.Length - 1])
        {
            rightMax = arr[arr.Length-2];
        }
        arr[arr.Length-2] = arr[arr.Length - 1];
        arr[arr.Length-1] = -1;        
        int temp;
        for (int i = arr.Length-3; i >=0; i--)
        {
            if (arr[i] < rightMax)
            {
                arr[i]= rightMax;
            }
            else if (arr[i] > rightMax)
            {
                temp = arr[i];                
                arr[i] = rightMax;
                rightMax = temp;
            }            
        }
    return arr;
    }    
}
int [] arr = new int [] {17,18,5,4,6,1};
// Console.WriteLine(String.Join(" ", arr));
int [] resultArray = ReplaceElements(arr);
Console.WriteLine(String.Join(" ", resultArray));