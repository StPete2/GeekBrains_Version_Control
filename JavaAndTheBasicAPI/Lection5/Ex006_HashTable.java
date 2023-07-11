package Lection5;

import java.util.*;

public class Ex006_HashTable {
    public static void main(String[] args) {
        Map<Integer,String> table = new Hashtable<>();
        table.put(1, "one");
        table.put(11, "wonderful");
        table.put(2, "two");
        Map<Integer, String> table2 = new Hashtable<>();
        System.out.println(table); // {2=один, 1=два, 11=один один}
        // table.put(null, "один"); //  java.lang.NullPointerException
        System.out.println(table.equals(table2));
    }
}
