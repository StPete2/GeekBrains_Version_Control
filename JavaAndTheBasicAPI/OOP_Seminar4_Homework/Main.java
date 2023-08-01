package OOP_Seminar4_Homework;

// import java.util.LinkedList;
// import java.util.List;

public class Main {
    public static void main(String[] args) {
        GBList<Integer> ll = new GBLinkedList<>();
        ll.addFirst(22);
        ll.addFirst(23);
        ll.addFirst(24);
        ll.addLast(25);
        // ll.addFirst(15);
        // ll.addLast(26);
        System.out.println(ll.size());
        System.out.println(ll.get(0));
        for (Integer integer : ll) {
            System.out.printf(integer + " ");
        }
        
    }
}
