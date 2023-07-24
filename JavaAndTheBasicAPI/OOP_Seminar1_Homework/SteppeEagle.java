package OOP_Seminar1_Homework;
public class SteppeEagle extends Animal implements Flyable{
    private int speed;

    public SteppeEagle(String namePet, String ownerName, String diagnosis, boolean isVaccinated, int speed){
        super(namePet, ownerName, diagnosis, isVaccinated);
        this.speed = speed;
    }

    public SteppeEagle(String name, int speed){
        this.namePet = name;
        this.speed = speed;
    }

    @Override
    public void toSwim(){
        System.out.printf("I am %s. I cann't swim. I am flying\n", TYPE);
    }
    @Override
    public void toRun(){
        System.out.printf("I am %s. I go, but mainly fly)\n", TYPE);
    }
    @Override
    public void toFly() {
        super.toFly();
    }
    @Override
    public int getFlyingSpeed() {
        return this.speed;     
    }    
}