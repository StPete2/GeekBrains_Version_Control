package Lection6;
import java.util.*;
public class Ex002_MathSet {
    public static void main(String[] args) {
        var a = new HashSet<>(Arrays.asList(1,2,3,4,5,6,7));
        var b = new HashSet<>(Arrays.asList(2,3,5,7,11,13,17));
        var u = new HashSet<Integer>(a); u.addAll(b); // добавление всех элементов из множества b
        var r = new HashSet<Integer>(a); r.retainAll(b); // вывод только пересечения элементов
        var s = new HashSet<Integer>(a); s.removeAll(b); // только остаток а, без b
        System.out.println(a); // [1, 2, 3, 4, 5, 6, 7]
        System.out.println(b); // [17, 2, 3, 5, 7, 11, 13]
        System.out.println(u); // [1, 17, 2, 3, 4, 5, 6, 11]
        System.out.println("Пересечение: " + r); // [2, 3, 5, 7]
        System.out.println("remove: " + s); // [1, 4, 6]

        System.out.println(a.addAll(b));
    }
}