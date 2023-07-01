// Дано четное число N (>0) и символы c1 и c2.
// Написать метод, который вернет строку длины N, которая
// состоит из чередующихся символов c1 и c2, начиная с c1.

package Seminar2;
import java.lang.System;
public class Task1 {
    public static void main(String[] args) {
        long s = System.currentTimeMillis();
        int n = 7;
        char c1 = 'A';
        char c2 = 'B';
        String result = alternatingChars(n, c1, c2);
        System.out.println(result);
        long s2 = System.currentTimeMillis(); 
        long s3 = System.nanoTime();       
        System.out.println(s2-s);
        System.out.println(s3);
    }
    public static String alternatingChars(int n, char c1, char c2) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i< n/2; i++){
            sb.append(c1);
            sb.append(c2);        
        }
        if (n %2 !=0)
            sb.append(c1);

        return sb.toString();
    }
    public static String alternatingCharsStr(int n, char c1, char c2) {
        String str = "";
        for (int i = 0; i < n / 2; i++) {
           str += Character.toString(c1)+ Character.toString(c2);
        }
        if (n % 2 != 0)
            str += c1;
        return str;
    }
}


// Character.toString(char)
// String.valueOf(c1)

