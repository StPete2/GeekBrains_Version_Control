package Lection2;
import java.io.File;

public class Ex002_fileSystemDemo {
    public static void main(String[] args) {
        String pathProject = System.getProperty("user.dir");
        String pathFile = pathProject.concat("\\file.txt"); //первая просто так
        File f3 = new File(pathFile);
        System.out.println(f3.getAbsolutePath());
        System.out.println(f3.exists());
        System.out.println(f3.getPath()); // тоже одинаковое
        System.out.println(pathFile); // одинаковое все.
        File f1 = new File("file.txt");
        System.out.println(f1.getAbsolutePath());
        
    }
}