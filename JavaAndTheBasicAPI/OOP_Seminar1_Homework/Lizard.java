package OOP_Seminar1_Homework;

public class Lizard extends Animal{
    
    private int tailLengthInSM;
    
    public Lizard(String namePet, String nameOwner, String diagnosis, boolean isVaccinated, int tailLength){
        super(namePet, nameOwner, diagnosis, isVaccinated);
        this.tailLengthInSM = tailLength;        
    }
    public Lizard(){
        this("Lizi", "OlgaSlis", "Earthy", false, 50);
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
}
