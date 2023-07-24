package OOP_Seminar1_Homework;

public class Lizard extends Animal implements Runnable{
    private int speed;
    private int tailLengthInSM;
    
    public Lizard(String namePet, String nameOwner, String diagnosis, boolean isVaccinated, int tailLength, int speed){
        super(namePet, nameOwner, diagnosis, isVaccinated);
        this.tailLengthInSM = tailLength;        
        this.speed = speed;
    }
    public Lizard(){
        this("Lizi", "OlgaSlis", "Earthy", false, 50, 3);
    }
    @Override
    public void toSwim(){
        System.out.printf("My name is %s. I am %s. I run, but not swim. Sorry\n", namePet,TYPE);
    }
    @Override
    public void toFly(){
        System.out.printf("My name is %s. I am %s. I run, but not swim. Sorry\n",namePet,TYPE);
    }
    public int getTailLength(){
        return tailLengthInSM;
    }
    @Override
    public void toRun() {
        System.out.println("This is an overriden method to run. I run");
    }
    @Override
    public int getRunningSpeed() {
        return this.speed;
    }

    public int setSpeed(int speed){
        return this.speed = speed;
    }
}
