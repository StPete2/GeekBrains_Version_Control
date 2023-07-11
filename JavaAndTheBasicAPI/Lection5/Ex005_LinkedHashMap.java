package Lection5;

import java.util.*;

public class Ex005_LinkedHashMap {
    public static void main(String[] args) {
        Map<Integer,String> linkmap = new LinkedHashMap<>();
        linkmap.put(11, "one-one");
        linkmap.put(1, "wonderful");
        linkmap.put(2, "one");
        System.out.println(linkmap); // {11=один один, 1=два, 2=один}
        Map<Integer,String> map = new HashMap<>();
        map.put(11, "one-one");
        map.put(2, "wonderful");
        map.put(1, "four");
        System.out.println(map); // {1=один, 2=два, 11=один один}
        System.out.println(linkmap.values());
        System.out.println(map.keySet());        
    }
}
