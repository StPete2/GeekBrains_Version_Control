package OOP_Seminar1_Homework;

public class Therapist extends Doctor{

    public Therapist(String doctorName, String doctorFamilyName, String doctorSpecialty, int grade,
            boolean medicalExamination, boolean takeTests, boolean isDoctor) {
        super(doctorName, doctorFamilyName, doctorSpecialty, grade, medicalExamination, takeTests, isDoctor);        
    }

    @Override
    public void doMedicalExamination() {
        System.out.println("Therapist does medical examination");        
    }
    
}
