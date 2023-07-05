// 2) Реализуйте очередь с помощью LinkedList со следующими методами:
// enqueue() - помещает элемент в конец очереди, 
// dequeue() - возвращает первый элемент из очереди и удаляет его, 
// first() - возвращает первый элемент из очереди, не удаляя.

package Seminar4_Homework;

import java.util.LinkedList;

public class Queue {
    LinkedList<Integer> ll;

    public Queue() {
        ll = new LinkedList<>();
    }

    public boolean empty() {
        return ll.isEmpty();
    }

    public void enqueue(int num) {
        ll.add(num);
    }

    public int dequeue() {
        if (empty()) {
            throw new IllegalStateException("Очередь пуста!");
        }
        return ll.pollFirst();
    }

    public int first() {
        if (empty()) {
            throw new IllegalStateException("Очередь пуста!");
        }
        return ll.getFirst();
    }

    public void print(){        
        for (Integer elem : ll) {
            System.out.print(elem + " ");
        }        
        System.out.println();
    }

    public static void main(String[] args) {        
        Queue queue = new Queue();                
        queue.enqueue(0);
        queue.enqueue(1);
        queue.enqueue(2);
        queue.enqueue(3);
        queue.enqueue(4);        
        queue.print();
        System.out.println("Dequeue: " + queue.dequeue());        
        System.out.println("First: "+ queue.first());
        System.out.println("Dequeue: " + queue.dequeue());
        queue.print();
        
    }
}
