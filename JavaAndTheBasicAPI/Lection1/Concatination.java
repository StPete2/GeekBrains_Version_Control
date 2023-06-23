package Lection1;

public class Concatination {
    public static void main(String[] args) {
        int a =1, b =2;
        int c = a+b;
        // String res = a + "+" + b + "=" + c;
        String res = String.format("%d + %d = %d", a,b,c);
        System.out.println(res);

        int min = a<b? a:b;
        System.out.println(min);
    }
}
