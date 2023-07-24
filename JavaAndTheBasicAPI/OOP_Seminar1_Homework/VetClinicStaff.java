package OOP_Seminar1_Homework;

import java.util.ArrayList;
import java.util.List;

public class VetClinicStaff {
    private final List<MedicalStaff> vetClinicStaff;
    public VetClinicStaff(){
        this.vetClinicStaff = new ArrayList<>();
    }
    public VetClinicStaff addVetClinicStaff(MedicalStaff person){
        vetClinicStaff.add(person);
        return this;
    }
    public List<MedicalStaff> getStaff(){
        return vetClinicStaff;
    }
    
    public void printVetClinicStaff(){
        for (MedicalStaff medicalStaff : vetClinicStaff) {
            System.out.println(medicalStaff);                    
        }                
    }    
}
