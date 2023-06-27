// Напишите метод, который составит строку, состоящую из 100
// повторений слова TEST и метод, который запишет эту строку в
// простой текстовый файл, обработайте исключения.

package Seminar2;

import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;

public class Task4 {
    public static void main(String[] args) {
        record (testString(100, "TEST"));        
    }

    static String testString(int count, String string){
        StringBuilder result = new StringBuilder();
        for (int i = 1; i < count+1; i++){
            // result.append(string);
            result.append(String.format("%d:%s\n", i, string));
        }        
        return result.toString();
    }

    static void record (String string){
        try (BufferedWriter writer = new BufferedWriter(new FileWriter("output.txt", false))){
        // FileWriter fw = new FileWriter(fileName);
            writer.write(string);
        }
        catch (IOException e) {
            System.out.println("Error" + e.getMessage());
        }
    }
}
