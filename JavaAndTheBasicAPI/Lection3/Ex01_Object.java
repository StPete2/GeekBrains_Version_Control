package Lection3;
public class Ex01_Object{
    public static void main(String[] args) {
        Object o = 1; 
        GetType(o);
        o = 1.2;
        GetType(o);
    }

    static void GetType(Object obj){
        System.out.println(obj.getClass().getName());
    }
}