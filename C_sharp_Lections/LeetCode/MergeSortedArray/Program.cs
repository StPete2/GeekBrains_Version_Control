void Merge(int[] nums1, int m, int[] nums2, int n)
{
    if (m == 0)
    {
        for (int i = 0; i < n; i++)
        {
            nums1[i] = nums2[i];
        }       
        return; 
    }
    else if (n == 0)
    {
        return;
    }
    
    else
    {
        for (int i = nums1.Length-1; i >= 0; i--)
        {
            if (nums1[m-1] > nums2[n-1])
            {
                nums1[i] = nums1[m-1];
                m--;
                // Console.WriteLine(String.Join(" ", nums1));
                if (m == 0)
                {
                    i--;
                    for (int j = n; j >=0; j--)
                    {
                        nums1[i] = nums2[n-1];
                        i--;
                        n--;
                        Console.WriteLine(String.Join(" ", nums1));
                        if (n == 0)
                        {
                            return;
                        }                        
                    }
                }
            }
            else
            {
                nums1[i] = nums2[n-1];
                n--;
                if (n == 0)
                {
                    return;
                }
            }
        }
        return;
    }
}    
int []nums1 = new int []{4,5,6,0,0,0};
int []nums2 = new int [] {1,2,3};
// int [] nums1 = new int []{1,2,3,0,0,0};
// int []nums2 = new int []{2,5,6};
Merge(nums1, 3, nums2, 3);
Console.WriteLine(String.Join(", ", nums1));