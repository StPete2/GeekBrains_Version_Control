package OOP_Seminar3;

import java.util.ArrayList;
import java.util.Collections;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

public class Main2 {
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
        
        System.out.println();
        System.out.println("Сила pharmacy1 больше силы pharmacy2 ? Ответ: " + pharmacy1.compareTo(pharmacy2));

        Pharmacy pharmacy4 = new Pharmacy();
        pharmacy4.addComponent(new Component("Peneciline", "0.6", 24))
                 .addComponent(new Component("Water", "1.2", 6));
        
        System.out.println("pharmacy3 equals pharmacy4: " + pharmacy3.equals(pharmacy4));

        Set <Pharmacy> result = new HashSet<>();
        result.add(pharmacy1);
        result.add(pharmacy2);
        result.add(pharmacy3);
        result.add(pharmacy4);
        System.out.println("Размер сета (4 pharmacy, два одинаковые): " + result.size());
        // System.out.println(result);
        
        System.out.println();
        System.out.println("Part 2. Comparing the components' names:");

        Pharmacy pharmacy5 = new Pharmacy();
        pharmacy5.addComponent(new Component("Penecilinf", "0.6", 24))
                 .addComponent(new Component("Water", "1.2", 6));
        
        System.out.println();
        System.out.println("Сила имен pharmacy4 больше силы имен компонентов pharmacy5 ? Ответ: " + pharmacy4.compareTo(pharmacy5));
            
        pharmacyList.add(pharmacy5);
        pharmacyList.add(pharmacy4);
        System.out.println(pharmacyList);
        Collections.sort(pharmacyList);
        System.out.println();
        System.out.println(pharmacyList);

    }
}