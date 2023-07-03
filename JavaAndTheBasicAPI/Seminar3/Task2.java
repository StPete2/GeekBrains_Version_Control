// Задание №2.1
// Заполнить список названиями планет Солнечной 
// системы в произвольном порядке с повторениями.
// Вывести название каждой планеты и количество его повторений в списке.

// Задание №2.2 (если выполнено первое задание)
// Пройти по списку из предыдущего задания и удалить повторяющиеся элементы.

package Seminar3;

import java.util.ArrayList;
import java.util.Collections;

public class Task2 {
    public static void main(String[] args) {
        ArrayList <String> planets = new ArrayList<>();
        planets.add(0, "Венера");
        planets.add(1, "Марс");
        planets.add(2, "Венера");
        planets.add(3, "Меркурий");
        planets.add(4, "Меркурий");
        planets.add(5, "Юпитер");
        Collections.sort(planets);
        int count =1;
        String planet = planets.get(0);                
        for (int i = 1; i < planets.size(); i++) {
            String currentPlanet = planets.get(i);
            if (planet.equals(currentPlanet)) {
                count +=1;
            }
            else {
                System.out.println(planet + "_" + count);
                count = 1;
                planet = currentPlanet;
            }
        }
        System.out.println(planet + "_" + count);
        planet = planets.get(0);
        for (int i = 1; i < planets.size(); i ++) {
            String currentPlanet = planets.get(i);
            if (currentPlanet.equals(planet)) {
                planets.remove(i);
            } 
            else {
                planet = currentPlanet;
            }
        }
        System.out.println(planets);
    }
}
