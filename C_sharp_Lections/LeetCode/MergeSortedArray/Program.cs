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
        if (nums2[0]>=nums1[m-1])
        {
            for (int i = 0; i < n; i++)
            {
                nums1[m+i]=nums2[i];
            }
            return;
        }        
        else if (nums2[n-1]<=nums1[0])
        {
            for (int i = m+n-1; i >=0; i--)
            {
                nums1[i] = nums1[i-n];
            }
            for (int i = 0; i < n; i++)
            {
                nums1[i] = nums2[i];
            }
            return;
        }
                
    }
}    
int []nums1 = new int []{4,5,6,0,0,0};
int []nums2 = new int [] {1,2,3};
// int [] nums1 = new int []{1,2,3,0,0,0};
// int []nums2 = new int []{2,5,6};
Merge(nums1, 3, nums2, 3);
Console.WriteLine(String.Join(", ", nums1));