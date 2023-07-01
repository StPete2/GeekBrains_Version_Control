package Seminar1;

import java.util.Arrays;

public class valueMoveToTheRight3 {
    public static void main(String[] args) {
        int[] nums = { 3, 2, 2, 3, 5,3, 0};
        int val = 3;
        int i = 0;
        int j = nums.length - 1;
        while (i < j) {
            if (nums[i] == val) {
                nums[i] = nums[j];
                nums[j] = val;
                j--;                
            } else {
                i++;
            }
        }
System.out.println(Arrays.toString(nums));
    }
}

