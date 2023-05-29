bool ValidMountainArray(int[] arr) 
{
    if (arr.Length < 3)
    {
        return false;
    }
    else
    {
        int max = -1;
        int mountainPeak = 0;
        bool uprising = false;
        bool descending = false;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i]>max)
            {
                mountainPeak = i;
            }
        }        
        int j = 1;
        for (int i = 0; i < mountainPeak; i++)
        {
            if (arr[j] > arr [i] && arr[j]!=arr[i])
            {
                uprising = true;
            }
            j++;
        }
        //Console.WriteLine("uprising = " + uprising);
        j = mountainPeak;
        // Console.WriteLine(mountainPeak, j, (arr.Length-1));
        Console.WriteLine(j);
        for (int k = mountainPeak+1; k < arr.Length; k++)
        {
            Console.WriteLine("descending = " + descending + "k = " + k);
            if (arr[j] > arr[k] && arr[j]!=arr[k])
            {
                descending = true;                
            }
            j++;            
        }
        Console.WriteLine("descending = " + descending);
        if (uprising == true && descending == true)
        {
            return true;
        }
        return false;
    }
}
int [] arr = new int [] {3,5,5};
int [] arr2 = new int [] {0,3,2,1};
bool result = ValidMountainArray(arr2);
Console.WriteLine(result);