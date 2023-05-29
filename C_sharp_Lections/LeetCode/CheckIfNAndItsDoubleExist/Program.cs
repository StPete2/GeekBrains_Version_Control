bool CheckIfExist(int[] arr)
{
    // for (int i = 0; i < arr.Length; i++)
    //     for (int j = 0; j < arr.Length; j++)
    //         if (i != j && arr[i] == 2 * arr[j])
    //             {
    //                 return true;
    //             }
    //         return false;    
    for (int i = 0; i <arr.Length; i++)
    {
        for (int j = 0; j < arr.Length; j ++)
        {
            if (i!=j && (arr[i]== 2 * arr[j] || (arr[i] == arr[j]/2 && arr[j]%2 == 0))) 
            {
                return true;
            }
        }
    }
    return false;
}
    
