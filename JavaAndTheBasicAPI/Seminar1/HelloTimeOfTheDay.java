// В консоли запросить имя пользователя. В зависимости от
// текущего времени, вывести приветствие вида
// "Доброе утро, <Имя>!", если время от 05:00 до 11:59
// "Добрый день, <Имя>!", если время от 12:00 до 17:59;
// "Добрый вечер, <Имя>!", если время от 18:00 до 22:59;
// "Доброй ночи, <Имя>!", если время от 23:00 до 4:59

package Seminar1;

import java.util.Calendar;
import java.util.Scanner;

public class HelloTimeOfTheDay {
    public static void main(String[] args) {
        Calendar now = Calendar.getInstance();
        int hour = now.get(Calendar.HOUR_OF_DAY);
        Scanner scanner = new Scanner(System.in, "Cp866");
        System.out.print("Введите свое имя: ");
        String name = scanner.nextLine();
        if (hour >=5 && hour <12){
            System.out.printf("Доброе утро, %s!",name);            
        }
        else if (hour >=12 && hour <18) {
            System.out.println("Добрый день, " + name + "!");            
        }
        else if (hour >=18 && hour <23) {
            System.out.println("Добрый вечер, " + name + "!");
        }
        // else if (hour >=23 || hour <5) {
        else {
            System.out.println("Доброй ночи, " + name + "!");
        }
        scanner.close();
    }
}
