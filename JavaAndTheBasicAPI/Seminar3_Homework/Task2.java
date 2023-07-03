// 2. Пусть дан произвольный список целых чисел, удалить из него четные числа

package Seminar3_Homework;

import java.util.ArrayList;
import java.util.Random;

public class Task2 {
    public static void main(String[] args) {        
        int size = 20;
        ArrayList <Integer> list1 = new ArrayList<>(size);
        int number;        
        Random random = new Random();
        for (int i = 0; i < size; i++) {
            number = random.nextInt(50);
            list1.add(i, number);            
        }
        System.out.println(list1);
        // list1.removeIf(n ->n %2 ==0);
        for (int i = 0; i < list1.size(); i++) {
            if (list1.get(i)%2 == 0) {
                list1.remove(i);
                i--;
            }
        }
        System.out.println(list1);
    }
}
