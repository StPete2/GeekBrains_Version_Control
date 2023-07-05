package Lection4;

import java.util.LinkedList;

public class Ex001 {
    public static void main(String[] args) {
        LinkedList<Integer> ll = new LinkedList<Integer>();

        ll.add(1);
        ll.add(2);
        ll.add(3);
        System.out.println(ll);
        System.out.println(ll.poll());
        System.out.println(ll);
        System.out.println(ll.peek());
        ll.set(1, 5);
        // System.out.println(ll.pop());
        System.out.println(ll);

    }
    
}
