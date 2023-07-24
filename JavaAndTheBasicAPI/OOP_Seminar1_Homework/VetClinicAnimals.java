package OOP_Seminar1_Homework;

import java.util.ArrayList;
import java.util.List;

public class VetClinicAnimals {
    private final List<Animal> animals;
    public VetClinicAnimals(){
        this.animals = new ArrayList<>();        
    }

    public VetClinicAnimals addNewAnimal(Animal animal){
        animals.add(animal);
        return this;
    }
    public List<Animal> getAnimals(){
        return animals;
    }
    public List<Animal> getFlyingAnimals(){
        List<Animal> result = new ArrayList<>();
        for (Animal animal : animals) {
            if (animal instanceof Flyable) {
                result.add(animal);
            }
        }
        return result;
    }
    public List<Animal> getRunnableAnimals(){
        List<Animal> result = new ArrayList<>();
        for (Animal animal : animals) {
            if (animal instanceof Runnable) {
                result.add(animal);
            }
        }
        return result;
    }

    public List<Animal> getSwimmableAnimals(){
        List<Animal> result = new ArrayList<>();
        for (Animal animal : animals) {
            if (animal instanceof Swimmable) {
                result.add(animal);
            }
        }
        return result;
    }
}
