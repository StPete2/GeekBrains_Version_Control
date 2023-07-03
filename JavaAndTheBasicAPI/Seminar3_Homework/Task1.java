// 1. Реализовать алгоритм сортировки слиянием

package Seminar3_Homework;

import java.util.Arrays;

public class Task1 {
    public static void main(String[] args) {
        int [] array = new int[] {2,9,7,8,6,5,1,0,3,4};
        System.out.println(Arrays.toString(array));
        mergeSort(array, array.length);
        System.out.println(Arrays.toString(array));

    }
    public static void mergeSort(int[]array, int size){
        if (array == null) {
            return;
        }
        else if (size < 2) {
            return;
        }
        int mid = size/2;
        int [] leftArray = new int [mid];
        int [] rightArray = new int [size-mid];
        for (int i = 0; i < mid; i++) {
            leftArray[i] = array[i];
        }
        for (int i = mid; i < size; i++) {
            rightArray[i-mid] = array[i];
        }
        mergeSort(leftArray, mid);
        mergeSort(rightArray, size-mid);
        merge(array, leftArray, rightArray, mid,size-mid);
    }
    public static void merge(int[]array, int []leftArray, int[]rightArray, int left, int right){
        int i =0;
        int j = 0;
        int k = 0;
        while (i<left && j <right) {
            if (leftArray[i]<=rightArray[j]) {
                array[k++]=leftArray[i++];
            } else {
                array[k++]= rightArray[j++];
            }
        }
        while (i<left) {
            array[k++]=leftArray[i++];
        }
        while (j<right) {
            array[k++]= rightArray[j++];
        }
    }
}
