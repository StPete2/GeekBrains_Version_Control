package OOP_Seminar1_Homework;

// import java.util.ArrayList;
// import java.util.List;

public abstract class MedicalStaff {
    
    protected String doctorName;
    protected String doctorFamilyName;
    protected String doctorSpecialty;
    protected int grade;
    protected boolean medicalExamination;
    protected boolean takeTests;
    protected boolean isDoctor;
    protected final String TYPE = getClass().getSimpleName();
    
    protected MedicalStaff(String doctorName, String doctorFamilyName, String doctorSpecialty, int grade, boolean medicalExamination, boolean takeTests, boolean isDoctor) {
        this.doctorName = doctorName;
        this.doctorFamilyName = doctorFamilyName;
        this.doctorSpecialty = doctorSpecialty;
        this.grade = grade;
        this.medicalExamination = medicalExamination;
        this.takeTests = takeTests;
        this.isDoctor = isDoctor;
    }
    public String getName(){
        return String.format("Name: %s, FamilyName: %s, %s", this.doctorName, this.doctorFamilyName, getType());
    }
    @Override
    public String toString(){
        return String.format("Name: %s, FamilyName: %s, %s", this.doctorName, this.doctorFamilyName, getType());
    }

    public String getGrade(){
        return String.format("Doctor %s has %s grade", this.doctorName, this.grade);
    }
    public int setGrade(int grade){
        return this.grade = grade;
    }
    public boolean doesMedicalExamination(){
        return this.medicalExamination;
    }
    public boolean setMedicalExamination(boolean medicalExamination){
        return this.medicalExamination = medicalExamination;
    }
    public boolean takesTests(){
        return this.takeTests;
    }
    public boolean setTakeTests(boolean takeTests){
        return this.takeTests = takeTests;
    }
    public boolean isDoctor(){
        return this.isDoctor;
    }
    public String getType(){
        return TYPE;
    }
    // protected final List<MedicalStaff> medicalStaff = new ArrayList<>();
    // // protected MedicalStaff(){
    // //     this.medicalStaff = new ArrayList<>();
    // // }
    // protected MedicalStaff addNewMedicalStaff(MedicalStaff name){
    //     medicalStaff.add(name);
    //     return this;
    // }
}

