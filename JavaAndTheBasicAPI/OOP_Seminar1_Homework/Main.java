package OOP_Seminar1_Homework;

public class Main {
    public static void main(String[] args) {
        Animal barsik = new Animal("Barsik", "Olga", "healthy", false);
        System.out.println("Barsik до прививки: " + barsik.isVaccinated());
        barsik.setVaccinated(true);
        System.out.println("Barsik после прививки: " + barsik.isVaccinated());
        System.out.println("Animal Barsik getType() = " + barsik.getType());

        Cat simpleCat = new Cat();
        System.out.println("SimpleCat = " + simpleCat.toStringSimple() + ". My number of paws = " + simpleCat.getCountPaws());

        Cat complexCat = new Cat("Lyubov", "OwnerFullName", "Healthy", true, 4);
        System.out.println("ComplexCat = " + complexCat);

        System.out.println("ComplexCat getType() = " + complexCat.getType());

        // complexCat.describeCatsDay();
        Lizard lizi = new Lizard();
        lizi.toGo();
        lizi.toFly();
        lizi.toSwim();
        System.out.println();
        
        // создание супер животного, которое может все (и летать, и ходить, и плавать)
        // Animal universalAnimal = new Animal("UNIQ", "SelfOwned", "Richy", true);
        // universalAnimal.toGo();
        // universalAnimal.toFly();
        // universalAnimal.toSwim();
        
        SteppeEagle lesha = new SteppeEagle();
        lesha.toFly();
        lesha.toGo();
        lesha.toSwim();
        System.out.println();        
        
        SwordFish swordy = new SwordFish("SwordySecond", "DeepSea", "WaterLoving", false, 100, false);
        swordy.toGo();
        swordy.toFly();
        swordy.toSwim();
        System.out.println();
        
        // поиски других вариантов, помимо переопределения наследованного метода.

        if (swordy instanceof SwordFish) {
            swordy.toSwim();
        } else {
            System.out.println("I implement only toSwim method");
        }
        
        if (swordy.canFly) {
            System.out.println("I am a SUPER SwordFish. I can FLY!");
        } else {
            swordy.toSwim();
            swordy.toGo(); // этот метод переопределен, поэтому выдает корректно все. 
            // иначе пришлось бы вводить вторую логическую переменную toGo.
        }
    }
}
