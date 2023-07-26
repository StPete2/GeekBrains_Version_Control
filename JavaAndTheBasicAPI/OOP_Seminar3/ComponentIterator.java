package OOP_Seminar3;

// import java.util.ArrayList;
import java.util.Iterator;
// import java.util.List;

public class ComponentIterator implements Iterator<Component>{
    private int index;
    // private List<Component> components = new ArrayList<>();
    private Pharmacy pharmacy;

    public ComponentIterator(Pharmacy pharmacy){
        this.pharmacy = pharmacy;        
    }

    @Override
    public boolean hasNext() {
        return index < pharmacy.getComponents().size();
    }

    @Override
    public Component next() {
        return pharmacy.getComponents().get(index++);
    }
    // public void example(){
    //     Pharmacy pharmacy = new Pharmacy();
    //     for (Iterator <Component> iterator = pharmacy.iterator(); iterator.hasNext();){
    //         Component c = iterator.next();
    //     }
    // }
}
