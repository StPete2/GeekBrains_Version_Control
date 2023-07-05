// 2) Реализуйте очередь с помощью LinkedList со следующими методами:
// enqueue() - помещает элемент в конец очереди, 
// dequeue() - возвращает первый элемент из очереди и удаляет его, 
// first() - возвращает первый элемент из очереди, не удаляя.
package Temp;

import java.util.LinkedList;
public class temp2 {
    public class Queue {
        LinkedList<Integer> ll;

        public Queue(){
            ll = new LinkedList<>();
        }

        public boolean empty(){
            return ll.isEmpty();
        }
        
        public void enqueue(int num) {
            ll.add(num);
        }
        public int dequeue(){
            if (empty()) {
                throw new IllegalStateException("Очередь пуста!");
            }
            return ll.pollFirst();
        }
        public int first(){
            if (empty()){
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
            temp2 task = new temp2();            
            Queue queue = task.new Queue();
            queue.enqueue(0);
            queue.enqueue(1);
            queue.enqueue(2);
            System.out.println(queue.first());
            System.out.println(queue.dequeue());
            queue.print();           
        }
    }
}