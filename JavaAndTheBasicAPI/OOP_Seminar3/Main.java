package OOP_Seminar3;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        Pharmacy pharmacy1 = new Pharmacy();
        pharmacy1.addComponent(new Component("Peneciline", "0.5", 15))
                .addComponent(new Component("Water", "1.2", 4));
        
        ComponentIterator ci = new ComponentIterator(pharmacy1);
        while (ci.hasNext()) {
            System.out.println(ci.next());
        }
        
        // Решение ниже уходит в бесконечный цикл!        
        // while (pharmacy.iterator().hasNext()){
        //     System.out.println(pharmacy.iterator().next());
        // }

        // Рабочее решение
        // for (Component component : pharmacy) {
        //     System.out.println(component);
        // }

        Pharmacy pharmacy2 = new Pharmacy();
        pharmacy2.addComponent(new Component("Peneciline", "0.6", 14))
                    .addComponent(new Component("Water", "1.2", 2));

        Pharmacy pharmacy3 = new Pharmacy();
        pharmacy3.addComponent(new Component("Peneciline", "0.6", 24))
                 .addComponent(new Component("Water", "1.2", 6));

        List<Pharmacy> pharmacyList = new ArrayList<>();
        pharmacyList.add(pharmacy1);
        pharmacyList.add(pharmacy2);
        pharmacyList.add(pharmacy3);
        System.out.println(pharmacyList);

        Collections.sort(pharmacyList);
        System.out.println();
        System.out.println(pharmacyList);
        
        System.out.println(pharmacy1.compareTo(pharmacy2));
    }
}
