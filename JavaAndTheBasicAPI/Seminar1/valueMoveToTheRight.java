package Seminar1;

public class valueMoveToTheRight {
    public static void main(String[] args) {
        int [] array = new int [] {1,3,2,3,4,3,0};
        int value = 3; 
        for (int i = 0; i<array.length; i++) {
            System.out.print(array[i] + " ");
        }
        System.out.println();
        method(array,value);
        for (int i = 0; i<array.length; i++) {
            System.out.print(array[i] + " ");
        }
    }
    static void method(int[]array, int value){
        int index = 0;
        int valCounter = 0;
        for (int i = 0; i< array.length; i++){
            if (array[i]==value) valCounter++;
        }        
        for (int i = array.length-1; i>=0; i--){
            if (array[i]!=value) {
                for (index = 0; index<array.length; index++){
                    if (array[index] == value) {
                        int temp = array[i];
                        array[i] = array[index];                                           
                        array[index] = temp;
                    } 
                }
            }            
        }
    }
}

