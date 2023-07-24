package OOP_Seminar1_Homework;

public class Nurse extends MedicalStaff implements TakesTests{

    public Nurse(String doctorName, String doctorFamilyName, String doctorSpecialty, int grade,
            boolean medicalExamination, boolean takeTests, boolean isDoctor) {
        super(doctorName, doctorFamilyName, doctorSpecialty, grade, medicalExamination, takeTests, isDoctor);
        
    }

    @Override
    public void takeTests() {
        System.out.println("Nurse takes tests, but not a medical examination");
        //throw new UnsupportedOperationException("Unimplemented method 'takeTests'");
    }

}
