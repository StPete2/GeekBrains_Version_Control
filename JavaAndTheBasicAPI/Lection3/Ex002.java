package Lection3;
import java.util.ArrayList;
public class Ex002 {

    public static void main(String[] args) {
        ArrayList<Integer> list = new ArrayList<Integer>();
        //ArrayList list = new ArrayList();
        list.add(2809);
        list.add(0, 1);
        list.add(2);

        for (Object o : list) {
            System.out.println(o);
        }
    }
}
