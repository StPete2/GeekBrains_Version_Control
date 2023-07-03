// 2) Реализуйте алгоритм сортировки пузырьком числового массива, результат
//  после каждой итерации запишите в лог-файл.
package Temp;
import java.io.IOException;
import java.util.Arrays;
import java.util.logging.FileHandler;
import java.util.logging.Level;
import java.util.logging.Logger;

public class temp1 {

    public static void main(String[] args, Logger logger) {        
        int [] array = {9,1,0,7,3,4,2,5,6,8};
        try {
            bubbleSort(logger, array);                    
        } catch (Exception e) {
            System.out.println("Exception e");
        }
        System.out.println(Arrays.toString(array));        
    }
    public static void bubbleSort(Logger logger, int [] array)throws IOException{
       
        int temp;
        boolean needSort;
        do {
            needSort = false;
            for (int i = 0; i < array.length-1; i++) {
                if (array[i]>array[i+1]) {
                    temp = array[i+1];
                    array[i+1] = array[i];
                    array[i]=temp;
                    needSort = true;
                }
                logging(logger, Arrays.toString(array));
            }
        } while (needSort);
    }
    public static Logger logFileCreated() throws IOException{
        Logger logger = Logger.getLogger(temp1.class.getName());
        String pathProject = System.getProperty("user.dir");
        String pathFile = pathProject.concat("\\log.txt");
        // System.out.println(pathFile);
        FileHandler fh = new FileHandler(pathFile);
        // SimpleFormatter sFormatter = new SimpleFormatter();
        // fh.setFormatter(sFormatter);
        logger.addHandler(fh); 
        return logger;
    }
    public static void logging (Logger logger, String str) throws IOException{
        logger.log(Level.INFO, str);        
    }
}