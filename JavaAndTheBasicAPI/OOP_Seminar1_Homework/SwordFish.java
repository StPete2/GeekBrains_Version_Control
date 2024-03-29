package OOP_Seminar1_Homework;

public class SwordFish extends Animal implements Swimmable{
    // private int lengthOfFish;
    boolean canFly;
    private int swimmingSpeed;

    public SwordFish(String namePet, String NameOwner, String diagnosis, boolean isVaccinated, int lengthOfFish, boolean canFly, int speed){
        super(namePet, NameOwner, diagnosis, isVaccinated);        
        // this.lengthOfFish = lengthOfFish;
        this.canFly = canFly;
        this.swimmingSpeed = speed;
    }
    public SwordFish(){
        super("Swordy", "Ocean", "Fish", false);        
        // this.lengthOfFish = 100;
    }
    @Override
    public void toRun(){
        System.out.println("I am a fish. I can't go, as I can breath air only in water");
    }
    @Override
    public void toFly(){
        System.out.println("I am a fish. I can't fly. Only in my dreams))");
    }
    @Override
    public void toSwim() {
        System.out.println("This is an overriden method to swim. I swim");
    }
    @Override
    public int getSwimmingSpeed() {
        return this.swimmingSpeed;        
    }
    public int setSwimmingSpeed(int speed){
        this.swimmingSpeed = speed;
        return this.swimmingSpeed;
    }

}
