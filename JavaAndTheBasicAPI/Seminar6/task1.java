// 1. Напишите метод, который заполнит массив из 1000 элементов случайными
// цифрами от 0 до 24.
// 2. Создайте метод, в который передайте заполненный выше массив и с
// помощью Set вычислите процент уникальных значений в данном массиве и
// верните его в виде числа с плавающей запятой.
// Для вычисления процента используйте формулу:
// процент уникальных чисел = количество уникальных чисел * 100 / общее
// количество чисел в массиве.

package Seminar6;

import java.util.HashSet;
// import java.util.Random;

public class task1 {
    public static void main(String[] args) {
        int[] array = getArray(1000);
        // System.out.println(Arrays.toString(array));    
        double uniq = getUniquePercent(array);
        System.out.println(uniq);
    }

    private static int[] getArray(int n){
        int[] result = new int[n];
        for (int i = 0; i < result.length; i++) {
            result[i] = (int)(Math.random()*24);
        }
        return result;
    }

    private static double getUniquePercent(int[] array){
        HashSet<Integer> hashSet = new HashSet<>();

        for (int itm : array) {
            hashSet.add(itm);
        }
        
        double uniq =  (double)hashSet.size() * 100 / array.length;
        return uniq;
    }

}
        // Random random = new Random();
        // number = random.nextInt(25);
        // int n = 100;
        // int []array = new int[n];
        // HashSet<Integer> hashSet = new HashSet<>();
