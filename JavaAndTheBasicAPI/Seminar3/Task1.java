// Заполнить список десятью случайными числами.
// Отсортировать список методом sort() и вывести его на
// экран.

package Seminar3;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Random;

public class Task1 {
    public static void main(String[] args) {
        ArrayList <Integer> list1 = new ArrayList<>(10);
        int number;
        for (int i = 0; i < 10; i++) {
            number = (int)(Math.random()*100);
            list1.add(i, number);
        }
        System.out.println(list1);
        Collections.sort(list1);
        System.out.println(list1);
        Random random = new Random();
        ArrayList <Integer> list2 = new ArrayList<>(10);
        for (int i = 0; i < 10; i++) {
            number = random.nextInt(100);
            list2.add(i, number);
        }
        System.out.println(list2);        
    }
}
