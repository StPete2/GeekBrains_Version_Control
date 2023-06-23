// Дан массив двоичных чисел, например [1,1,0,1,1,1], вывести
// максимальное количество подряд идущих 1.
package Seminar1;

public class massiveMaxInARow {
    public static void main(String[] args) {
        int [] array = new int []{1,1,0,1,1,1,0};
        int counter1 = 0;
        int maxCounter = 0;
        for (int i = 0; i < array.length; i++){
            if (array[i] == 1) {
                counter1++;                          
            }
            else {
                if (counter1 > maxCounter) {
                    maxCounter = counter1;
                } 
                counter1 = 0;
            }
        }
        if (counter1 > maxCounter) maxCounter = counter1;
        System.out.println(maxCounter);
    }
}
