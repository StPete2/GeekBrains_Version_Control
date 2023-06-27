// Напишите метод, который вернет содержимое текущей папки в виде
// массива строк.
// Напишите метод, который запишет массив, возвращенный предыдущим
// методом в файл.
// Обработайте ошибки с помощью try-catch конструкции. В случае
// возникновения исключения, оно должно записаться в лог-файл.

package Seminar2;
import java.io.File;
import java.util.logging.FileHandler;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.logging.SimpleFormatter;
public class Task5_2 {
    
    static Logger logger = Logger.getLogger(Task5_2.class.getName());
    public static void main(String[] args) {
        try {
            FileHandler fh = new FileHandler("log.txt");
            SimpleFormatter sFormat = new SimpleFormatter();
            fh.setFormatter(sFormat);
            logger.log(Level.INFO, "log.txt");
                        
        } catch (Exception e) {
            // logger.log(Level.WARNING, e.getMessage());
        }
        String file = ".";
        String[] allFiles = getList(file);

    }
    static String[] getList(String fileName){
        File file = new File(fileName);
        String [] strPath = file.list();
        return strPath;
    }
    static void writeToFile(String fileName, String []data){
        
    }
}
