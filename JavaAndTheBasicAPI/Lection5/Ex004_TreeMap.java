package Lection5;

import java.util.*;

public class Ex004_TreeMap {
    public static void main(String[] args) {
        TreeMap<Integer,String> tMap = new TreeMap<>();
        tMap.put(1,"one"); System.out.println(tMap); 
        // {1=один}
        tMap.put(6,"seven"); System.out.println(tMap);
        // {1=один, 6=шесть}
        tMap.put(4,"four"); System.out.println(tMap);
        // {1=один, 4=четыре, 6=шесть}
        tMap.put(3,"three"); System.out.println(tMap);
        // {1=один, 3=три, 4=четыре, 6=шесть}
        tMap.put(2,"two"); System.out.println(tMap);
        // {1=один, 2=два, 3=три, 4=четыре, 6=шесть}
        System.out.println(tMap.descendingMap());
        System.out.println(tMap.lowerEntry(3));
    }
}
