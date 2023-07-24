package OOP_Seminar1_Homework;

public class Animal {
    protected String namePet;
    protected String nameOwner;
    protected String diagnosis;
    protected boolean isVaccinated;
    protected final String TYPE = getClass().getSimpleName();

    public Animal (){        
    }

    public Animal(String namePet, String nameOwner, String diagnosis, boolean isVaccinated){
        this.namePet = namePet;
        this.nameOwner = nameOwner;
        this.diagnosis = diagnosis;
        this.isVaccinated = isVaccinated;
    }
    public boolean isVaccinated(){
        return this.isVaccinated;
    }
    public void setVaccinated(boolean isVaccinated){
        this.isVaccinated = isVaccinated;        
    }
    public String getType(){
        return TYPE;
    }
    @Override
    public String toString(){
        return String.format("%s{name} = %s, owner = %s, diagnosis = %s, isVaccinated = %b",  TYPE, namePet, nameOwner, diagnosis, isVaccinated);
    }
    public String toStringSimple(){
        return String.format("%s{name} = %s, owner = %s", TYPE, namePet, nameOwner);
    }
    public String getType(String arg){
        return arg + TYPE;
    }

    protected void toRun(){
        System.out.printf("My name is %s. I am %s. I implement super() toRun method. I like walking\n", namePet,TYPE);
    }
    protected void toFly(){
        System.out.printf("My name is %s. I am %s. I implement super() toFly method. I am flying\n", namePet,TYPE);
    }
    protected void toSwim(){
        System.out.printf("My name is %s. I am %s. I implement super() toSwim method. I swim very well\n", namePet, TYPE);
    }
}
