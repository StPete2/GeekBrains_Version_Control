package OOP_Seminar1_Homework;

public class Paramedic extends Doctor{

    public Paramedic(String doctorName, String doctorFamilyName, String doctorSpecialty, int grade,
            boolean medicalExamination, boolean takeTests, boolean isDoctor) {
        super(doctorName, doctorFamilyName, doctorSpecialty, grade, medicalExamination, takeTests, isDoctor);        
    }

    @Override
    public void doMedicalExamination() {
        System.out.println("Paramedic also does medical examination");
        //throw new UnsupportedOperationException("Unimplemented method 'doMedicalExamination'");
    }
}
