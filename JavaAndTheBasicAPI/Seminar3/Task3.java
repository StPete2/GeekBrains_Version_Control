// Задание №3
// Создать список типа ArrayList<String>.
// Поместить в него как строки, так и целые числа.
// Пройти по списку, найти и удалить целые числа.

package Seminar3;

import java.util.ArrayList;
import java.util.List;

public class Task3 {
    public static void main(String[] args) {
        ArrayList<String> list1 = new ArrayList<>();
        list1.add(0, "Asdf");
        list1.add(1, "4");            
        list1.add(2, "1"); 
        list1.add("etwas");
        list1.add("nochEinMal");
        System.out.println(list1);

        removeDigits(list1);
        System.out.println(list1);
    }
    private static void removeDigits(List <String> list1){
        for (int i = 0; i < list1.size(); i++) {
            if (parsString(list1.get(i))) {
                list1.remove(i);
                i--;
                System.out.println("i = " + i);
            }
            System.out.println("i2 = " + i);
        }        
    }
    
    private static boolean parsString(String str){
        try {
            Integer.parseInt(str);
            return true;
        } catch (Exception e) {
            return false;
        }
    }
}
