// Даны следующие строки, cравнить их с помощью == и
// метода equals() класса Object
// String s1 = "hello";
// String s2 = "hello";
// String s3 = s1;
// String s4 = "h" + "e" + "l" + "l" + "o";
// String s5 = new String("hello");
// String s6 = new String(new char[]{'h', 'e', 'l', 'l', 'o'});

package Seminar3;

public class Task0 {
    public static void main(String[] args) {
        String s1 = "hello";
        String s2 = "hello";
        String s3 = s1;
        String s4 = "h" + "e" + "l" + "l" + "o";
        String s5 = new String("hello");
        String s6 = new String(new char[]{'h', 'e', 'l', 'l', 'o'});            
        
        if (s1==s2) {
            System.out.println("s1 равно s2");
        }
        if (s1 == s3) {
            System.out.println("s1 равно s3");
        }
        if (s1 == s4) {
            System.out.println("s1 равно s4");
        }
        if (s1 == s5) {
            System.out.println("s1 равно s5");
        } else {
            System.out.println("s1 is not the same as s5");
        }
        if (s1 == s6) {
            System.out.println("s1 равно s6");
        } else if (s1.equals(s6)) {
            System.out.println("s1 equals s6");
        }
        
        else {
            System.out.println("s1 is not the same as s6");
        }
    }
}
