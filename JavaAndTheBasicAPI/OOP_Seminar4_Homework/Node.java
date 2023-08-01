package OOP_Seminar4_Homework;

public class Node <E>{
    private Node<E> prevElement;
    private E currentElement;
    private Node<E> nextElement;

    public Node(Node<E> prevElement, E currentElement, Node<E> nextElement){
        this.currentElement = currentElement;
        this.prevElement = prevElement;
        this.nextElement = nextElement;
    }
    public E getCurrentElement(){
        return currentElement;
    }
    public void setCurrentElement(E currentElement){
        this.currentElement = currentElement;
    }
    public Node<E> getNextElement(){
        return nextElement;
    }
    public Node<E> getNextElement(Node<E> current){
        return current.getNextElement();
    }
    
    public void setNextElement(Node<E> nextElement){
        this.nextElement = nextElement;
    }
    public Node<E> getPrevElement(){
        return prevElement;
    }
    public void setPrevElement(Node<E> prevElement){
        this.prevElement = prevElement;
    }
}
