package Temp;

import java.util.Scanner;
import java.util.logging.FileHandler;
import java.util.logging.Level;
import java.util.logging.Logger;

// / import java.util.logging.SimpleFormatter;
import java.io.IOException;

public class temp0 {
    public static void main(String[] args) throws IOException {
        Scanner iScanner = new Scanner(System.in);
        double x = Double.parseDouble(getValue("Введите первое число: ", iScanner));
        double y = Double.parseDouble(getValue("Введите второе число: ", iScanner));
        String sign = getValue("Введите символ операции +, -, * или / :", iScanner);
        try {
            calculator(x, y, sign);            
        } catch (Exception e) {
            System.out.println("Error:");
        }
        iScanner.close();
    }
    public static String getValue(String str, Scanner iScanner){        
        System.out.print(str);        
        String value = iScanner.nextLine();         
        return value;
    }
    
    public static void calculator(double x, double y, String sign) throws IOException{        
        
        switch (sign) {
            case "+":
                System.out.printf("%f + %f = %f", x, y, x+y);
                logging(String.format("%f + %f = %f", x,y,x+y));
                break;
            case "-":
                System.out.printf("%f - %f = %f", x, y, x-y);
                logging(String.format("%f - %f = %f", x,y,x-y));
                break;
            case "*":
                System.out.printf("%f * %f = %f", x, y, x*y);
                logging(String.format("%f * %f = %f", x,y,x*y));
                break;                
            case "/":
                System.out.printf("%f / %f = %f", x, y, x/y);
                logging(String.format("%f / %f = %f", x,y,x/y));
                break;        
            default:
                System.out.println("Вы ввели некоректный знак. Программа завершает свою работу");    
                logging("Вы ввели некоректный знак. Программа завершает свою работу");
                break;
        }
    }
    public static void logging(String str) throws IOException{
        Logger logger = Logger.getLogger(temp0.class.getName());
        String pathProject = System.getProperty("user.dir");
        String pathFile = pathProject.concat("\\calcLogger.txt");
        FileHandler fh = new FileHandler(pathFile);
        // SimpleFormatter sFormatter = new SimpleFormatter();
        // fh.setFormatter(sFormatter);
        logger.addHandler(fh);
        logger.log(Level.INFO, str);
    }
}