package Lection4;

import java.util.*;

public class Ex004 {
    public static void main(String[] args) {
        Stack<Integer> stack = new Stack<>();
        stack.push(1);
        stack.push(12);
        stack.push(123);
        System.out.println(stack.pop()); // 123
        System.out.println(stack.pop()); // 12
        System.out.println(stack.pop()); // 1
        stack.add(0, 1);
        stack.add(1, 2);
        System.out.println(stack.peek());
        System.out.println(stack.get(0));        
    }
}
