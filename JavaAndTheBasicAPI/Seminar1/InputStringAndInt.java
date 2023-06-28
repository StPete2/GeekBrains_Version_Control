package Seminar1;

import java.util.Scanner;

public class InputStringAndInt {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in, "Cp866");
        System.out.print("Введите Ваше имя: ");
        String name = scanner.nextLine();
        // System.out.println("Привет, " + name + "!");
        System.out.printf("Привет, %s!", name);
        System.out.println();
        System.out.print("Введите число: ");
        int num = scanner.nextInt();
        System.out.println(num);
        scanner.close();
    }
}
