package Lection1;

public class programArray {
    public static void main(String[]arg) {
        int [] arr []= new int [3][5];
        for (int []line:arr) {
            for (int item:line) {
                System.out.printf("%d ", item);
            }
            System.out.println();
        }
        System.out.println();
        int [][] arr2 = new int [4][3];
        for (int i = 0; i<arr2.length; i++) {
            for (int j = 0; j <arr2[i].length; j++){
                System.out.printf("%d ", arr2[i][j]);
            }
            System.out.println();
        }
    }
}
