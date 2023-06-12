int RemoveElement(int[] nums, int val) {
    int valCounter = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == val && i!=nums.Length-1)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                if (nums[j]!=val)
                {
                    nums[i]=nums[j];                    
                    i++;
                    valCounter++;                    
                    Console.WriteLine(valCounter);
                    Console.WriteLine(String.Join(" ", nums));                                        
                }
                else if (j == nums.Length-1)
                {
                    return valCounter;
                }
            }
        }
        else if (nums[i] == val && i == nums.Length-1)
        {
            return valCounter;
        }
        
        else
        {
            valCounter++;
        }
    }
    return valCounter;
}
int [] nums = new int [] {2,2,3};
int val = 2;
int result = RemoveElement(nums, val);
Console.WriteLine(result);
Console.WriteLine(String.Join(", ", nums));
// int [] nums2 = new int [] {0,1,2,2,3,0,4,2};
// int val2 = 2;
// int result2 = RemoveElement(nums2,val2);
// Console.WriteLine(result2);
// Console.WriteLine(String.Join(" ", nums2));