// Реализуйте структуру телефонной книги с помощью HashMap.
// Программа также должна учитывать, что во входной структуре будут повторяющиеся 
// имена с разными телефонами, их необходимо считать, как одного человека с разными
//  телефонами. Вывод должен быть отсортирован по убыванию числа телефонов.

package Seminar5_Homework;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
// import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
// import java.util.Map;

public class task1 {
    public static void main(String[] args) {
        String inputData = "{\"Ivanov\":\"+7915\", \"Petrov\":\"+7905\", \"Sidorov\":\"+7906\", \"Ivanov\":\"+79117\", \"Przhevalskiy\":\"+7901\", \"Sidorov\":\"+7903\", \"Ivanov\":\"+7906\", \"Petrov\":\"+7921\"}";
        System.out.println("Исходная строка: ");
        System.out.println(inputData);
        System.out.println();
        // System.out.println(Arrays.toString(getStringArray(inputData)));        
        
        HashMap <String, List<String>> phoneBook = new HashMap<>();
        phoneBook = getPhoneBookHashMap(getStringArray(inputData));
        System.out.println("HashMap несортированный: ");
        System.out.println(phoneBook);
        System.out.println();
        
        ArrayList<HashMap.Entry<String,List<String>>> sortedList = new ArrayList<>();
        sortedList = sortedList (phoneBook);
        System.out.println("Вывод данных из HashMap в отсортированном порядке: ");
        printList(sortedList);

    }

    public static String [] getStringArray(String inputData){
        String interimString = inputData.replace("{", "");
        interimString = interimString.replace("}", "");
        interimString = interimString.replace("\"", "");
        interimString = interimString.replace(" ", "");
        String [] array = interimString.split(",");
        return array;
    }

    public static HashMap<String, List<String>> getPhoneBookHashMap(String [] array){
        HashMap<String, List<String>> phoneBookHashMap = new HashMap<>();
        String [] interimStringArray;
        for (String string : array) {
            interimStringArray = string.split(":");
            if (!phoneBookHashMap.containsKey(interimStringArray[0])) {
                List<String> additionalList = new ArrayList<>();                
                additionalList.add(0, interimStringArray[1]);
                phoneBookHashMap.put(interimStringArray[0], additionalList);
            } else {
                List<String> additionalListExists = new ArrayList<>();
                additionalListExists = phoneBookHashMap.get(interimStringArray[0]);
                additionalListExists.add(0, interimStringArray[1]);
                phoneBookHashMap.replace(interimStringArray[0], additionalListExists);
            }        
        }
        return phoneBookHashMap;
    }

    public static ArrayList<HashMap.Entry<String, List<String>>> sortedList (HashMap<String,List<String>> phoneBookHashMap){
        ArrayList <HashMap.Entry<String, List<String>>> sortedList = new ArrayList<>(phoneBookHashMap.entrySet());
        Collections.sort(sortedList, new Comparator<HashMap.Entry<String, List<String>>>() {
            @Override
            public int compare(HashMap.Entry<String, List<String>> o1, HashMap.Entry<String,List<String>> o2){
                return o2.getValue().size() - o1.getValue().size();
            }
        }); 
        return sortedList;       
    }

    public static void printList (ArrayList<HashMap.Entry<String, List<String>>> sortedList ){
        for (HashMap.Entry<String,List<String>> entry : sortedList) {
            System.out.println(entry.getKey() + ":" + entry.getValue());
        }
    }
}
