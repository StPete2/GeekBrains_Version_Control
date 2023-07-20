package OOP_Seminar1_Homework;

public class Cat extends Animal{
    private int countPaws;
    
    public Cat(String animalName, String ownerName, String diagnosis, boolean isVaccinated, int countPaws){
        super(animalName, ownerName, diagnosis, isVaccinated);
        this.countPaws = countPaws;
    }

    // public Cat(){        
    // }
    public Cat(){
        this("Max", null, "Healthy", false, 4);
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
        System.out.println("Кот заснул");
    }
    public void describeCatsDay(){
        wakeup();
        findFood();
        eat();
        sleep();
    }
    public int getCountPaws(){
        return countPaws;
    }
}
