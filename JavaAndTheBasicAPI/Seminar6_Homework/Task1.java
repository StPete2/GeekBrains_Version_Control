package Seminar6_Homework;

import java.util.ArrayList;
import java.util.HashMap;
// import java.util.List;
// import java.util.Map;
import java.util.Scanner;

public class Task1 {
    public static void main(String[] args) {                       
        ArrayList<Laptop> laptops = getLaptops();
        printLaptops(laptops);

        Scanner iScanner = new Scanner(System.in);
        
        HashMap<String, String> filterData = new HashMap<>();
        filterData = getFilterData(iScanner);
        System.out.println(filterData);

        ArrayList<Laptop> filteredLaptops = getFilteredLaptops(laptops, filterData);
        printFilteredLaptops(filteredLaptops);

        iScanner.close();
    }   
    public static HashMap<String, String> getFilterData(Scanner iScanner)  {
        HashMap<String, String> filterData = new HashMap<>();
        System.out.println("Введите критерии для фильтрации...");
        System.out.println("Нажмите '1' для ввода фильтра по размеру экрана");
        System.out.println("Нажмите '2' для ввода фильтра по размеру RAM");
        System.out.println("Нажмите '3' для ввода фильтра по размеру SSD");
        System.out.println("Нажмите esc для сохранения введенных фильтров");
        String inputData = iScanner.nextLine();
        while (!inputData.equalsIgnoreCase("esc")) {
            if (inputData.equals("1")) {
                System.out.println("Введите минимальный размер экрана в дюймах: ");
                String screenSize = iScanner.nextLine();
                if (!isNumeric(screenSize)) {
                    System.out.println("Вы ввели некорректное значение!");
                } else {
                    filterData.put("1", screenSize);
                }
            }
            else if (inputData.equals("3")) {
                System.out.println("Введите минимальный размер SSD: ");
                String ssdSize = iScanner.nextLine();
                if (!isNumeric(ssdSize)) {
                    System.out.println("Вы ввели некорректное значение!");
                } else {
                    filterData.put("3", ssdSize);
                }
            }
            else if (inputData.equals("2")) {
                System.out.println("Введите минимальный размер RAM: ");
                String screenSize = iScanner.nextLine();
                if (!isNumeric(screenSize)) {
                    System.out.println("Вы ввели некорректное значение!");
                } else {
                    filterData.put("2", screenSize);
                }
            } else {
                System.out.println("Вы ввели некорректное значение!");
            }
            System.out.println("Продолжите ввод параметров, набрав '1', '2' или '3' или наберите esc для начала фильтрации: ");
            inputData = iScanner.nextLine();
        }
        return filterData;
    }

    public static void printLaptops(ArrayList <Laptop> laptops){
        System.out.println("Ноутбуки в наличии: ");
        for (Laptop laptop : laptops) {
            System.out.println(laptop);            
        }
        System.out.println();
    }
    public static ArrayList<Laptop> getLaptops (){
        ArrayList<Laptop> laptops = new ArrayList<>();
        Laptop laptop1 = new Laptop("Asus", "15VC01", 15.0, 8, 250, null, "Black");
        laptops.add(laptop1);
        Laptop laptop2 = new Laptop("Acer", "17V1", 17.0, 4, 500, "Windows", "Silver");
        laptops.add(laptop2);
        Laptop laptop3 = new Laptop("Lenovo", "17L3", 17.0, 8, 1024, "Linux", "Blue");
        laptops.add(laptop3); 
        return laptops;
    }
    public static ArrayList<Laptop> getFilteredLaptops(ArrayList<Laptop> laptops, HashMap<String,String> filterData){
        ArrayList<Laptop> filteredLaptops = new ArrayList<>();
        for (Laptop laptop : laptops) {
            if (laptop.getScreenSize()>=parseFilterData(filterData.get("1")) && laptop.getRamSize()>=parseFilterData(filterData.get("2")) && laptop.getSsdSize()>=parseFilterData(filterData.get("3"))) {
                filteredLaptops.add(laptop);
            }
        }
        return filteredLaptops;
    }
    public static double parseFilterData (String inputString){
        if (inputString == null) {
            return 0.0;
        // } else if (!isNumeric(inputString)) {
        //     return 0.0;
        } else {
        double getData = Double.parseDouble(inputString);
        return getData;
        }
    }
    public static void printFilteredLaptops(ArrayList<Laptop>laptops){
        if (laptops.size()==0) {
            System.out.println("Ноутбуков, удовлетворяющих введенным критериям, не найдено");            
        } else {
            System.out.println("Список отсортированных ноутбуков: ");
            for (Laptop laptop : laptops) {
                System.out.println(laptop);
            }
        }
    }
    public static boolean isNumeric(String str){
        char [] charArray = str.toCharArray();
        for (char c : charArray) {
            if (!Character.isDigit(c)) {
                return false;
            }
        }
        return true;
    }
}
