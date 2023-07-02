// 2) Вывести все простые числа от 1 до 1000

package Seminar1_Homework;

import java.util.ArrayList;
import java.util.List;

public class Task2 {
    public static void main(String[] args) {
        int n = 1000;
        System.out.println(findSimpleNumbers(n));

    }
    private static List<Integer> findSimpleNumbers(int maxNumber){
        List <Integer> result = new ArrayList<>();
        for (int i = 2; i <= maxNumber; i++) {
            boolean simpleNumber = true;
            for (int j = 2; j <= i/2; j++) {
                if (i % j ==0) {
                    simpleNumber = false;
                }
            }
            if (simpleNumber) {
                result.add(i);
            }
        }
        return result;
    }
}
