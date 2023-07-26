package OOP_Seminar3;

import java.util.Objects;

public class Component {
    private String name;
    private String weight;
    private int power;

    public Component(String name, String weight, int power) {
        this.name = name;
        this.weight = weight;
        this.power = power;
    }
    public int getPower(){
        return this.power;
    }
    public String getName(){
        return this.name;
    }
    public String getWeigth(){
        return this.weight;
    }
    @Override
    public String toString(){
        return String.format("%s \"%s\", вес: %s, сила: %s", getClass().getSimpleName(), this.name, this.weight, this.power);
    }

    @Override
    public boolean equals(Object o){
        if (this == o) return true;
        if (o==null || getClass()!=o.getClass()) return false;
        Component component = (Component) o;
        return getName() == component.getName() && getWeigth() == component.getWeigth() && getPower() == component.getPower();
    }
    @Override
    public int hashCode(){
        return Objects.hash(getName(),getWeigth(), getPower());
    }
}
