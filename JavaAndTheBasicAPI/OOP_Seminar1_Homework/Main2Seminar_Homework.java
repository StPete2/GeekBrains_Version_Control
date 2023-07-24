package OOP_Seminar1_Homework;

import java.util.List;

public class Main2Seminar_Homework {
    public static void main(String[] args) {
        Doctor doctor1 = new Therapist("Alex", "StPete", "GP", 10, true, false, true);
        Paramedic paramedic1 = new Paramedic("Max", "Verstappen", "null", 7, true, false, true);
        Nurse nurse1 = new Nurse("Maria", "Kombarova", "Senior Nurse", 2, false, true, false);
        
        System.out.println("Introduction part. Medical Staff, some info about them: ");
        System.out.println("1."+ doctor1.getName());
        System.out.println("2." + paramedic1.getGrade());
        System.out.println("3." + nurse1.getType());
        System.out.println();

        VetClinicStaff vcs = new VetClinicStaff();
        vcs.addVetClinicStaff(doctor1).addVetClinicStaff(paramedic1).addVetClinicStaff(nurse1);
        // List<MedicalStaff> staff = vcs.getStaff();
        System.out.println("Part no. 1. Список медицинского персонала: ");
        // System.out.println(staff);
        vcs.printVetClinicStaff();
        System.out.println();

        //System.out.println(doctor1.doesMedicalExamination());
        Therapist doctor2 = new Therapist("AdditionalName", "FamilyName", "Therapist", 9, true, false, true);
        
        System.out.println("Part no. 2. Interfaces, medical staff: ");
        doctor2.doMedicalExamination();    
        paramedic1.doMedicalExamination();
        nurse1.takeTests();               
        
        System.out.println();        

        SteppeEagle eagle = new SteppeEagle("Eagle", 195);
        Cat barsik = new Cat();
        SwordFish swordy = new SwordFish();
        // Animal lizzi = new Lizard(); 
        Lizard lizzi = new Lizard();
        VetClinicAnimals vca = new VetClinicAnimals();

        vca.addNewAnimal(eagle).addNewAnimal(barsik).addNewAnimal(swordy);
        vca.addNewAnimal(lizzi);
        
        System.out.println("Part no. 3. Interfaces, animals: ");
        List<Animal> flying = vca.getFlyingAnimals();
        System.out.println("Flying: " + flying);

        
        List<Animal> runnable = vca.getRunnableAnimals();
        System.out.println("Runnable: " + runnable);
        // List<Animal> allAnimals = vca.getAnimals();
        // System.out.println(allAnimals);
        
        List<Animal> swimmable = vca.getSwimmableAnimals();
        System.out.println("Swimmable: " + swimmable);
        
        System.out.println();
        System.out.println("Part no. 4. Running, Flying and Swimming speed: ");
        eagle.toFly();
        System.out.println("Eagle Flying Speed: " + eagle.getFlyingSpeed() + "km/h");
        lizzi.setSpeed(3);
        System.out.println("Lizard running speed is: " + lizzi.getRunningSpeed() + "km/h");
        lizzi.toRun();        
        swordy.setSwimmingSpeed(15);
        System.out.println("Swordy swimming speed is: " + swordy.getSwimmingSpeed() + "km/h");
        swordy.toSwim();
    }
}
