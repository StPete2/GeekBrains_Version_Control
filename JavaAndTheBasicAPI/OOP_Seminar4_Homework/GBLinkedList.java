package OOP_Seminar4_Homework;

import java.util.Iterator;

public class GBLinkedList<E> extends Node<E> implements GBList<E> {

    private Node<E> firstNode;
    private Node<E> lastNode;
    private int size = 0;

    public GBLinkedList() {
        super(null, null, null);
        firstNode = new Node<E>(null, null, lastNode);
        lastNode = new Node<E>(firstNode, null, null);
    }

    @Override
    public Iterator<E> iterator() {
        return new Iterator<E>() {
            int counter = 0;

            @Override
            public boolean hasNext() {
                return counter < size;
            }

            @Override
            public E next() {
                return get(counter++);
            }

        };
    }

    @Override
    public boolean addFirst(E e) {
        try {
            Node<E> first = firstNode;
            Node<E> newNode = new Node<E>(null, e, first);
            firstNode = newNode;
            // first.setCurrentElement(e);
            // firstNode = new Node<E>(null,null, first);
            // first.setPrevElement(firstNode);
            if (first == null) {
                lastNode = newNode;
            } else {
                first.setPrevElement(newNode);
            }
            size++;

            return true;
        } catch (Exception exception) {
            System.out.println("Нода не добавлена!");
            return false;
        }
    }

    @Override
    public boolean addLast(E e) {
        try {
            Node<E> last = lastNode;
            // last.setCurrentElement(e);
            Node<E> newNode = new Node<E>(last, e, null);
            // lastNode = new Node<E>(last,null, null);
            // last.setNextElement(lastNode);
            lastNode = newNode;
            if (last == null)
                firstNode = newNode;
            else
                last.setNextElement(newNode);
            size++;
            return true;

        } catch (Exception exception) {
            System.out.println("Нода не добавлена");
            return false;
        }
    }

    @Override
    public E get(int index) {
        Node<E> target = firstNode;
        for (int i = 0; i < index; i++) {
            target = target.getNextElement(target);
        }
        return target.getCurrentElement();
    }

    @Override
    public int size() {
        return size;
    }
    // @Override
    // public String toString(){
    // return String.format("");
    // }
}
