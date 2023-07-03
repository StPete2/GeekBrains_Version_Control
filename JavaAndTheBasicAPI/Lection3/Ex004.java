package Lection3;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;

public class Ex004 {
    public static void main(String[] args) {
        int day = 29;
        int month = 9;
        int year = 1990;
        Integer[] date = { day, month, year };
        List<Integer> d = Arrays.asList(date);
        System.out.println(d); // [29, 9, 1990]
        Integer [] array = new Integer[]{1,2,3,4,5};
        List <Integer> list1 = new ArrayList<>();
        Collections.addAll(list1, array);
        System.out.println(list1);
    }
}