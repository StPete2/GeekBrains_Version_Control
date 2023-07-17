// Животное для ветеринарной клиники

package OOP_Seminar1;

/**
 * Animal
 */
public class Animal {
    // поля класса
    protected String nameAnimal;
    protected String ownerName;
    protected String diagnosis;
    protected boolean isVaccinated;
    protected final String TYPE = getClass().getSimpleName();
    // private final String TYPE = getClass().getName();

    public Animal(String animal, String ownerName, String diagnosis, boolean isVaccinated){
        this.nameAnimal = animal;
        this.ownerName = ownerName;
        this.diagnosis = diagnosis;
        this.isVaccinated = isVaccinated;
    }

    public Animal(){

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
        return String.format("%s{name} = %s, owner = %s", TYPE, nameAnimal, ownerName);
    }
    public String getType(String arg){
        return arg + TYPE;
    }
}