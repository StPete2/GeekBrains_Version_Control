void Merge(int[] nums1, int m, int[] nums2, int n)
{
    if (m == 0)
    {
        for (int i = 0; i < n; i++)
        {
            nums1[i] = nums2[i];
        }
    }
    else
    {
        // int l = nums1.Length;
        int successMerge = 0;
        // int temp=0;
        for (int i = n-1; i >=0; i--)
        {
            if (nums2[i] > nums1[m-1-successMerge])
            {
                nums1[m+i] = nums2[i];                
                successMerge++;                
            }
            else if (nums2[i] < nums1[m-1-successMerge])
            {
                // temp = successMerge;
                nums1[m+i-successMerge] = nums1[m-1-successMerge];                                       
                // nums1[m-1-successMerge] = 0;   
                i++;                                     
                // Console.WriteLine($"{i}:{m-1-successMerge}:{successMerge}");
                successMerge++;                                                                        
            }                
            // successMerge++;
        }
    }
}    
int []nums1 = new int []{4,5,6,0,0,0};
int []nums2 = new int [] {1,2,3};
// int [] nums1 = new int []{1,2,3,0,0,0};
// int []nums2 = new int []{2,5,6};
Merge(nums1, 3, nums2, 3);
Console.WriteLine(String.Join(", ", nums1));