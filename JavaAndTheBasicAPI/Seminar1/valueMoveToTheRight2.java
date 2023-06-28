package Seminar1;

import java.util.Arrays;

public class valueMoveToTheRight2 {
    public static void main(String[] args) {
        valueMoveToTheRight2 task = new valueMoveToTheRight2();
        task.go();
    }

    private void go() {
        int [] array = new int[] {3,2,2,5, 3, 4, 3,0,3};
        System.out.println(Arrays.toString(array));
        int val = 3;
        int lastItem = array.length - 1;
        for (int i = lastItem; i >= 0; i--) {
            if (array[i] == val) {
                swap(array, i, lastItem--);
                System.out.println(Arrays.toString(array));
            }
        }

        for (int i = 0; i < array.length; i++) {
            System.out.print(array[i] + " ");
        }
    }

    private int [] swap(int [] arr, int x, int y) {
        int temp = arr[x];
        arr[x] = arr[y];
        arr[y] = temp;
        return arr;
    }
}
