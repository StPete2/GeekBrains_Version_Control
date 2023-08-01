package OOP_Seminar4_Homework;

public interface GBList <E> extends Iterable<E>{
    boolean addFirst(E e);
    boolean addLast(E e);
    E get(int index);
    int size();
}
