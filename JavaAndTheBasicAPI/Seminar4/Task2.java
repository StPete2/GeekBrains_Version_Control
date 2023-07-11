//  Реализовать консольное приложение, которое:
// 1. Принимает от пользователя и “запоминает” строки.
// 2. Если введено print, выводит строки так, чтобы последняя введенная
// была первой в списке, а первая - последней.
// 3. Если введено revert, удаляет предыдущую введенную строку из памяти.

package Seminar4;

import java.util.Scanner;

public class Task2 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Введите строки для запоминания или введите esc: ");
        String str = sc.nextLine();
        returnStack(str, sc);
        sc.close();

    }
    public static java.util.Stack <String> returnStack(String str, Scanner sc){
        java.util.Stack <String> stack = new java.util.Stack<>();
        int index = 0;
        while (!str.equalsIgnoreCase("esc")) {
            if (str.equalsIgnoreCase("print")) {
                if (index==0) {
                    System.out.println("Стек пустой");
                } else {                
                    for (int i = index-1; i >=0; i--) {
                        System.out.println(stack.elementAt(i));
                    }
                }
                // System.out.println(stack.toString());
            } else if (str.equalsIgnoreCase("revert")) {
                if (index!=0) {
                    stack.remove(index-1); 
                    index--;                   
                } else {
                    System.out.println("Стек пустой. Для удаление элемента вначале введите его.");
                }
            } else {
                stack.add(index,str);                
                index++;
            }
            str = sc.nextLine();

        }
        return stack;
    }
}
