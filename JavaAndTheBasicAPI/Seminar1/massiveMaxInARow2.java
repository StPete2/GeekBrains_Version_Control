// Проверить работу, разобрать

package Seminar1;

public class massiveMaxInARow2 {
    public static void main(String[] args) {
        int[] array = new int[] { 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0 };
        System.out.println(getMax(array));
        System.out.println(getMax2(array));
    }

    static int getMax(int[] array) {
        int cont = 0;
        int maxCount = 0;
        for (int i = 0; i < array.length; i++) {
            if (array[i] == 1) {
                cont++;
            } else {
                if (maxCount < cont)
                    maxCount = cont;
                cont = 0;
            }
        }
        if (maxCount < cont)
            maxCount = cont;
        return maxCount;
    }

    static int getMax2(int[] array) {
        int cont = 0;
        int maxCount = 0;
        for (int i : array) {
            if (i == 1) {
                cont++;
            } else {
                if (maxCount < cont)
                    maxCount = cont;
                cont = 0;
            }
        }
        if (maxCount < cont)
            maxCount = cont;
        return maxCount;
    }

}
