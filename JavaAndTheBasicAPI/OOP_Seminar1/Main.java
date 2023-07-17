package OOP_Seminar1;

import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        Animal animal = new Animal();
        Animal barsik = new Animal("Barsik", "Olga", "Prostuda", false);
        barsik.isVaccinated();        
        System.out.println(barsik.isVaccinated());
        barsik.setVaccinated(true);
        System.out.println(barsik.isVaccinated());
        // barsik.setVaccinated(false);
        // System.out.println(barsik.isVaccinated());
        System.out.println(barsik.getType());
        Cat cat = new Cat();
        System.out.println(cat);
        System.out.println(cat.getType());
        Animal tricky = new Cat("TrickyCat", "Aleksey", "Poor", false, 4);
        // Cat tricky2 = new Animal(); - выдает ошибку, работать не будет. Type mismatch
        Dog pesik = new Dog();
        List<Animal> animals = new ArrayList<>();
        animals.add(cat);
        animals.add(pesik);
        animals.add(tricky);
        System.out.println(animals);
        System.out.println(tricky.getType("argument "));
        System.out.println(tricky.getType());
        
        // cat.wakeup(); - после инкапсуляции 4 методов вывести их не получится
        // cat.findFood();
        // cat.eat();
        // cat.sleep();
        cat.hunt();
        // Механизм сокрытия внутренней логики внутри класса или метода и 
        // выдача наружу только того, что считаем необходимым.
    }
}
