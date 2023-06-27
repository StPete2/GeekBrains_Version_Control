// Напишите метод, который принимает на вход строку (String) и
// определяет является ли строка палиндромом (возвращает
// boolean значение).

package Seminar2;

public class Task3 {
    public static void main(String[] args) {
        String str = "abcba";
        System.out.println(isPalindrom(str));
    }

    public static boolean isPalindrom(String input) {
        input = input.toUpperCase();
        int len = input.length();
        for (int i = 0; i < len / 2; i++) {
            if (input.charAt(i) != input.charAt(len - i - 1)) {
                return false;
            }
        }
        return true;
    }
}
