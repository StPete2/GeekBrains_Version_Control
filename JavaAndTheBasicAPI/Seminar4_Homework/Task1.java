// 1) Пусть дан LinkedList с несколькими элементами. 
// Реализуйте метод, который вернет “перевернутый” список.

package Seminar4_Homework;

import java.util.LinkedList;

public class Task1 {
    public static void main(String[] args) {
        LinkedList<Integer> ll = new LinkedList<>();
        ll.add(0);
        ll.add(1);
        ll.add(2);
        ll.add(3);
        ll.add(4);
        // ll.add(5);
        System.out.println(ll);
        System.out.println();
        revertList(ll);
        System.out.println(ll);
    }
    public static void revertList(LinkedList<Integer> list){
        int j = 0;
        int temp;
        for (int i = list.size()-1; i >= list.size()/2; i--) {
            temp = list.get(j);
            list.set(j, list.get(i));
            list.set(i, temp);            
            j++;
        }
    }
}
