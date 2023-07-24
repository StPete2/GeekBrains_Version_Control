package OOP_Seminar1_Homework;

public abstract class Doctor extends MedicalStaff implements DoesMedicatlExamination{

    public Doctor(String doctorName, String doctorFamilyName, String doctorSpecialty, int grade,
            boolean medicalExamination, boolean takeTests, boolean isDoctor) {
        super(doctorName, doctorFamilyName, doctorSpecialty, grade, medicalExamination, takeTests, isDoctor);        
    }
    
}
