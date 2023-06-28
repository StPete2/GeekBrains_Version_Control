// 1) Вычислить n-ое треугольного число (сумма чисел от 1 до n), n! 
// (произведение чисел от 1 до n)

package Seminar1_Homework;

import java.util.Scanner;

public class Task1 {
    public static void main(String[] args) {
        int n = getNumber();
        System.out.printf("Сумма чисел от 1 до n равна: %d\n", sumNumber(n));
        System.out.printf("Произведение чисел от 1 до n равно: %d", factorial(n));
    }
    private static int getNumber(){
        Scanner iScanner = new Scanner(System.in);
        System.out.print("Введите целое положительное число: ");
        int number = iScanner.nextInt();
        iScanner.close();        
        return number;
    }

    private static int factorial(int number){
        int result = 1;
        for (int i = 1; i <= number; i++) {
            result *=i;
        }
        return result;
    }

    private static int sumNumber (int number){
        int summa = 0;
        for (int i = 1; i <= number; i++) {
            summa += i;
        }
        return summa;
    }
}
