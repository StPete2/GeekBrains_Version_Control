package OOP_Seminar1;

public class Cat extends Animal {
    private int countPaws;

    public Cat(){
        this("Max", null, null, false, 4);
    }
    public Cat(String animal, String ownerName, String diagnosis, boolean isVaccinated, int countPaws){
        super(animal, ownerName, diagnosis, isVaccinated);
        this.countPaws = countPaws;
    }

    private void wakeup(){
        System.out.println("Кот проснулся");        
    }
    private void findFood(){
        System.out.println("Кот нашел еду");        
    }
    private void eat(){
        System.out.println("Кот поел");
    }
    private void sleep(){
        System.out.println("Кот уснул");
    }
    public void hunt(){
        wakeup();
        findFood();
        eat();
        sleep();
    }
    public int getPaws(){
        return countPaws;
    }
}
