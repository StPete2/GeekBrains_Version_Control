// 3. Задан целочисленный список ArrayList. Найти минимальное, максимальное и 
// среднее из этого списка.

package Seminar3_Homework;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Random;

public class Task3 {
    public static void main(String[] args) {
        int size = 10;
        Random random = new Random();
        ArrayList <Integer> list1 = new ArrayList<>(size);
        int number;
        double summa =0;
        for (int i = 0; i < size; i++) {
            number = random.nextInt(10);
            list1.add(i, number);            
            summa +=number;
        }
        System.out.println(list1);
        int minElement = Collections.min(list1);
        int maxElement = Collections.max(list1);
        System.out.println("Минимальное значение равно: " + minElement);
        System.out.println("Максимальное значение равно: " + maxElement);
        // System.out.println(summa);
        double avarage = summa/list1.size();
        System.out.println("Среднее значение равно: " + avarage);

    }
}
