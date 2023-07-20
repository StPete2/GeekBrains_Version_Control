package OOP_Seminar1_Homework;
public class SteppeEagle extends Animal{

    public SteppeEagle(){
        super();
    }
    @Override
    public void toSwim(){
        System.out.printf("I am %s. I cann't swim. I am flying\n", TYPE);
    }
    @Override
    public void toGo(){
        System.out.printf("I am %s. I go, but mainly fly)\n", TYPE);
    }
}