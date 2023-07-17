package Seminar6_Homework;

public class Laptop {
    private String brand;
    private String model;
    private double screenSize;
    private int ramSize;
    private int ssdSize;
    private String OS;
    private String color;

    public Laptop(String brand, String model, double screenSize, int ramSize, int ssdSize, String OS, String color){
        this.brand = brand;
        this.model = model;
        this.screenSize = screenSize;
        this.ramSize = ramSize;
        this.ssdSize = ssdSize;
        this.OS = OS;
        this.color = color;
    }
    public String getBrand(){
        return brand;        
    }
    public String getModel(){
        return model;
    }
    public double getScreenSize(){
        return screenSize;
    }
    public int getRamSize(){
        return ramSize;
    }
    public int getSsdSize(){
        return ssdSize;
    }
    public String getOS(){
        return OS;
    }
    public String color(){
        return color;
    }
    public String getInfo(){
        return String.format("Марка: %s, модель: %s, размер экрана: %.1f, RAM: %d, SSD: %d, OS: %s, цвет: %s", brand,model,screenSize,ramSize,ssdSize,OS,color);        
    }
    @Override
    public String toString(){
        return getInfo();
    }
}
