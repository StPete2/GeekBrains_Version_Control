package OOP_Seminar1;

import java.util.ArrayList;
import java.util.List;

public class VetClinic {
    private final List<Animal> animals;
    
    public VetClinic(){
        this.animals = new ArrayList<>();        
    }

    public VetClinic addNewAnimal(Animal animal){
        animals.add(animal);
        return this;
    }

    public List<Animal> getAnimals(){
        return animals;
    }
    public static int index;
    public int index1;

    public List<Animal> getFlyingAnimals(){
        List<Animal> result = new ArrayList<>();
        for (Animal animal : animals) {
            if (animal instanceof Flyable) {
                result.add(animal);
            }
        }
        return result;
    }
}
