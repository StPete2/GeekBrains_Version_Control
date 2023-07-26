package OOP_Seminar3;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.Iterator;
import java.util.List;

public class Pharmacy implements Iterable<Component>, Comparable<Pharmacy>, Comparator<Pharmacy>{
// public class Pharmacy implements Iterator<Component>{
    private int index;
    private final List<Component> components;

    public List<Component> getComponents(){
        return components;
    }

    public Pharmacy(){
        this.components = new ArrayList<>();
        this.index = 0;
    }

    public Pharmacy addComponent(Component component){
        components.add(component);
        return this;
    }    
    public int getIndex(){
        return index;
    }
    private int getPharmacyPower(){
        int power = 0;
        for(Component component : components){
            power += component.getPower();
        }
        return power;
    }

    @Override
    public String toString(){        
        return String.format("\n%s Состав: %s, сила: %s", getClass().getSimpleName(), this.components, this.getPharmacyPower());
    }
    
    // как только пишешь implements Iterable<Component>, программа предлагает добавить 
    // вначале один метод iterator(), а потом, когда добавляешь new Iterator<>(),
    // программа автоматически предлагает переопределить 2 метода в Итераторе

    // @Override
    // public Iterator<Component> iterator() {
    //     return new Iterator<Component>() {

    //         @Override
    //         public boolean hasNext() {
    //             // TODO Auto-generated method stub
    //             throw new UnsupportedOperationException("Unimplemented method 'hasNext'");
    //         }

    //         @Override
    //         public Component next() {
    //             // TODO Auto-generated method stub
    //             throw new UnsupportedOperationException("Unimplemented method 'next'");
    //         }
            
    //     };
    // }

    @Override
    public Iterator<Component> iterator() {
        return new ComponentIterator(this);
    }

    @Override
    public int compareTo(Pharmacy o) {
        if(this.getPharmacyPower()>o.getPharmacyPower()) return 1;
        else if (this.getPharmacyPower()<o.getPharmacyPower()) return -1;
        else {
            return addtionalCompareNames(o);
        }
    }
    public int addtionalCompareNames(Pharmacy o)    {
        StringBuilder componentNamePower1 = new StringBuilder();
        StringBuilder componentNamePower2 = new StringBuilder();
        for (Component component : this.getComponents()) {
            componentNamePower1.append(component.getName());
        }
        for (Component component : o.getComponents()) {
            componentNamePower2.append(component.getName());
        }     
           
        return (componentNamePower1.toString().compareTo(componentNamePower2.toString()));            
    
        // return this.getPharmacyPower()>o.getPharmacyPower()? 1: ((this.getPharmacyPower()==o.getPharmacyPower())? 0:-1);
        // 1. Надо составить строку из составляющих компонента
        // 2. Надо объединить в строку полученные строки из компонентов.
    }

    @Override
    public int compare(Pharmacy o1, Pharmacy o2) {
        if(o1.getPharmacyPower()>o2.getPharmacyPower()) return 10;
        else if (o1.getPharmacyPower()<o2.getPharmacyPower()) return -10;
        return 0;
        
        // return o1.compareTo(o2);
    }
    @Override
    public boolean equals(Object o){
        if (this == o) return true;
        if (o == null || getClass()!=o.getClass()) return false;
        Pharmacy pharmacy = (Pharmacy) o;
        for (int i = 0; i < components.size(); i++) {
            if (!this.getComponents().get(i).equals(pharmacy.getComponents().get(i))) {
                return false;
            }
        }
        return true;
    }
    @Override
    public int hashCode(){
        final int PRIME = 31;
        int result = 1;
        for (int i = 0; i < components.size(); i++) {
            result += PRIME * result + ((getComponents().get(i)==null) ? 0:getComponents().get(i).hashCode());            
        }      
        
        return result;
    }


    // @Override
    // public Iterator<Component> iterator() {
    //     return new Iterator<>(){

    //         @Override
    //         public boolean hasNext() {
    //             return index < components.size();
    //         }

    //         @Override
    //         public Component next() {
    //             // Component component = components.get(index);
    //             // index++;
    //             // return component;
    //             return components.get(index++);
    //         }
    //     };
    // }
}
//https://docs.oracle.com/javase/tutorial/extra/generics/