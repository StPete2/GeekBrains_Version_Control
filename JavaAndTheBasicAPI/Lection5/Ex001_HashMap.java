package Lection5;

import java.util.*;
 
public class Ex001_HashMap {
    public static void main(String[] args) {
        Map<Integer, String> db = new HashMap<>();
        db.putIfAbsent(1, "one"); 
        db.put(2, "two"); 
        db.put(null, "!null"); 
        System.out.println(db); // {null=!null, 1=один, 2=два}
        System.out.println(db.get(44));
        //db.remove(null); 
        System.out.println(db); // {1=один, 2=два}
        System.out.println(db.containsValue("one")); // true
        System.out.println(db.containsValue("1")); // false
        System.out.println(db.containsKey(12)); // false
        System.out.println(db.containsKey(1)); // true
        System.out.println(db.keySet());
        System.out.println(db.values());


    }
}