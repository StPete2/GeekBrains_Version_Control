package Lection4;

import java.util.*;

public class Ex003 {
    public static void main(String[] args) {
        Deque<Integer> deque = new ArrayDeque<>();
        deque.addFirst(1); deque.addLast(2);
        System.out.println(deque);
        deque.removeLast(); deque.removeLast();
        System.out.println(deque);
        deque.offerFirst(3); deque.offerLast(4);
        System.out.println(deque);
        deque.pollFirst(); deque.pollLast();
        deque.add(5);
        System.out.println(deque);
        int a = deque.getFirst(); deque.getLast();
        System.out.println(a);
        deque.addFirst(6);
        int b = deque.peekFirst(); deque.peekLast();
        System.out.println(b);
    }
}