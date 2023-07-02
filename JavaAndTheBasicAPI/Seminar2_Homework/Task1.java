// 1) Дана строка sql-запроса "select * from students where ".
// Сформируйте часть WHERE этого запроса, используя StringBuilder.
// Данные для фильтрации приведены ниже в виде json-строки.
// Если значение null, то параметр не должен попадать в запрос.
// Параметры для фильтрации: {"name":"Ivanov", "country":"Russia", 
// "city":"Moscow", "age":"null"}

package Seminar2_Homework;

public class Task1 {
    public static void main(String[] args) {
        String sql = "select * from students where ";
        String filter = "{\"name\":\"Ivanov\", \"country\":\"Russia\", \"city\":\"Moscow\", \"age\":\"null\"}";
        String result = formQuery(sql, filter);
        System.out.println(result);
        
    }   
    private static String formQuery(String str1, String str2){
        String interimString = str2.replace("{", "");
        interimString = interimString.replace("}", "");
        interimString = interimString.replace("\"", "");
        interimString = interimString.replace(":", " = ");
        String [] array = interimString.split(",");
        StringBuilder resultQuery = new StringBuilder(str1);        
        for (int i = 0; i < array.length; i++) {
            if (array[i].endsWith("null")) {        
                continue;                
            }
            resultQuery.append(array[i] + " and");                        
        }
        int cap = resultQuery.length();        
        resultQuery.delete(cap - 4,cap);
        return resultQuery.toString();
    }
}
