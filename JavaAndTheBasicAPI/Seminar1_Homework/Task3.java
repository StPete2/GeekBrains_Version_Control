// 3) Реализовать простой калькулятор
package Seminar1_Homework;
import java.util.Scanner;

public class Task3 {
    public static void main(String[] args) {
        int x = firstNumber();
        int y = secondNumber();
        String str = getSign();
        switch (str) {
            case "+":
                System.out.printf("%d + %d = %d", x, y, x+y);
                break;
            case "-":
                System.out.printf("%d - %d = %d", x, y, x-y);
                break;
            case "*":
                System.out.printf("%d * %d = %d", x, y, x*y);
                break;
            case "/":
                System.out.printf("%d / %d = %d", x, y, x/y);
                break;
            default:
                System.out.println("Вы ввели некоректный знак. Программа завершает свою работу");
                break;
        }

    }
    public static int firstNumber(){
        Scanner iScanner = new Scanner(System.in);
        System.out.print("Введите первое число: ");
        int number = iScanner.nextInt();
        //iScanner.close();
        return number;
    }

    public static int secondNumber(){
        Scanner iScanner = new Scanner(System.in);
        System.out.print("Введите второе число: ");
        int number = iScanner.nextInt();
        //iScanner.close();
        return number;
    }

    public static String getSign(){
        Scanner iScanner = new Scanner(System.in);
        System.out.print("Введите арифметический знак + , -, *, /: ");
        String str = iScanner.nextLine();
        iScanner.close();
        return str;
    }
}
