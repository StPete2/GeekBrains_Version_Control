// 3) В калькулятор добавьте возможность отменить последнюю операцию.

package Seminar4_Homework;

import java.util.Scanner;
import java.util.Stack;

public class Task2 {
    public static double res;
    public static Stack<Double> resultStack = new Stack<>();
    
    public static boolean isDigit(String str) throws NumberFormatException{
        try {
            Double.parseDouble(str);
            return true;
        } catch (NumberFormatException e) {
            return false;
        }
    }

    public static void main(String[] args) {
        Scanner iScanner = new Scanner(System.in);
        System.out.println("Введите первое число или esc для выхода из программы: ");
        String str = iScanner.nextLine();
        //System.out.println(calculator(iScanner, str));
        calculator(iScanner, str);
        iScanner.close();
    }

    public static Stack <Double> calculator (Scanner iScanner, String str){
        Stack <String> stackCommon = new Stack<>();
        Stack <Double> stackDouble = new Stack<>();
        
        while (!str.equalsIgnoreCase("esc")) {
            if (str.equalsIgnoreCase("redo")){
                System.out.println("reverting...");
                if (resultStack.isEmpty()){
                    System.out.println("Fisrt Notice: Отмена невозможна! Операций не производилось");
                } else {
                    stackDouble.pop();
                    stackDouble.push(revertOperation(resultStack));                    
                }
            }
            else if (isDigit(str) && stackDouble.size()==0) {
                double x = Double.parseDouble(str);
                stackDouble.push(x);                
            } else if (isDigit(str) && stackDouble.size()==1 && stackCommon.size()==1) {
                double x = Double.parseDouble(str);
                stackDouble.push(x);
                makeCalc(stackCommon, stackDouble);
            
            } else if (isDigit(str) && stackDouble.size()==1 && stackCommon.size()==0) {
                double x = Double.parseDouble(str);
                stackDouble.push(x);

            } else if (isDigit(str) && stackDouble.size()>1 && stackCommon.size()==0) {
                System.out.println("Вы ввели более 2-х цифр подряд без арифметического знака. Буду посчитаны последние две цифры");
                double x = Double.parseDouble(str);
                stackDouble.push(x);

            } else if (!isDigit(str) && stackDouble.size()>=2){
                stackCommon.push(str);
                makeCalc(stackCommon, stackDouble);

            } else if (!isDigit(str) && stackCommon.size()==0){
                stackCommon.push(str);
            } else if (!isDigit(str) && stackCommon.size()>0) {
                System.out.println("Вы ввели более 2-х арифметических знаков подряд. Будет произведена последняя введенная операция");
                stackCommon.clear();
                stackCommon.push(str);
            }

            System.out.println("Введите второе число, арифметический знак или esc для выхода из программы: ");
            System.out.println("Введите redo для отмены последней операции: ");
            str = iScanner.nextLine();
        }
        return stackDouble;
    }

    public static double makeCalc (Stack <String> stStr, Stack <Double> stDouble) {
        
        String sign = stStr.pop();
        switch (sign) {
            case "+":
                res = stDouble.pop() + stDouble.pop();
                stDouble.clear();
                System.out.println("Подитог = " + stDouble.push(res));
                resultStack.push(res);
                break;
            case "-":
                res = -stDouble.pop() + stDouble.pop();
                stDouble.clear();
                System.out.println("Подитог = " + stDouble.push(res));                
                resultStack.push(res);
                break;
            case "*":
                res = stDouble.pop() * stDouble.pop();
                stDouble.clear();
                System.out.println("Подитог = " + stDouble.push(res));
                resultStack.push(res);
                break;
            case "/":
                res = 1 / stDouble.pop() * stDouble.pop();
                stDouble.clear();
                System.out.println("Подитог = " + stDouble.push(res));
                resultStack.push(res);
                break;
            default:
                System.out.println("Вы ввели некорректный знак");
                break;
        }
        return res;
    }

    public static double revertOperation(Stack<Double> resStack){
        resStack.pop();
        if (resStack.size()==0) {
            resStack.push(0.0);
        }
        res = resStack.peek();
        System.out.println("Second notice: Операция отменена. Последнее значение равно: ");
        System.out.println(res);    
        if (resStack.get(0)==0.0) {
            resStack.pop();
        }    
        return res;
    }
}
