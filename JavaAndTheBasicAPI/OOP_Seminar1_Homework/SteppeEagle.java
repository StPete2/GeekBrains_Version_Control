package OOP_Seminar1_Homework;
public class SteppeEagle extends Animal implements Flyable{

    public SteppeEagle(){
        super();
    }
    public SteppeEagle(String name){
        this.namePet = name;
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
}