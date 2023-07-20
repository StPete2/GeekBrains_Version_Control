package OOP_Seminar1_Homework;

public class SwordFish extends Animal{
    int lengthOfFish;
    boolean canFly;

    public SwordFish(String namePet, String NameOwner, String diagnosis, boolean isVaccinated, int lengthOfFish, boolean canFly){
        super(namePet, NameOwner, diagnosis, isVaccinated);        
        this.lengthOfFish = lengthOfFish;
        this.canFly = canFly;
    }
    public SwordFish(){
        super("Swordy", "Ocean", "Fish", false);
    }
    @Override
    public void toGo(){
        System.out.println("I am a fish. I can't go, as I can breath air only in water");
    }
    @Override
    public void toFly(){
        System.out.println("I am a fish. I can't fly. Only in my dreams))");
    }

}
