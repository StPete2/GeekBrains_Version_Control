package notebook.view;

import notebook.controller.UserController;
import notebook.model.User;
import notebook.util.Commands;

// import java.util.ArrayList;
import java.util.List;
// import java.util.Scanner;

public class UserView {
    private final UserController userController;

    public UserView(UserController userController) {
        this.userController = userController;
    }

    public void run(){
        Commands com;

        while (true) {
            String command = userController.prompt("Введите команду: ");
            com = Commands.valueOf(command);
            if (com == Commands.EXIT) return;
            switch (com) {
                case CREATE:
                    User u = userController.creatUser();
                    userController.saveUser(u);
                    break;
                case READ:
                    String id = userController.prompt("Идентификатор пользователя: ");
                    try {
                        User user = userController.readUser(Long.parseLong(id));
                        System.out.println(user);
                        System.out.println();
                    } catch (Exception e) {
                        throw new RuntimeException(e);
                    }
                    break;
                case UPDATE:
                    String userId = userController.prompt("Enter user id: ");
                    userController.updateUser(userId, userController.creatUser());
                    break;
                case SHOW_LIST:
                    List<User> users = userController.readAll();
                    System.out.println(users);
                    break;
                case NONE:
                    System.out.println("Bingo! You have selected the NONE choice. Please, select another one, if you don't mind :-)");
                    break;
            }
        }
    }

    // private String prompt(String message) {
    //     Scanner in = new Scanner(System.in);
    //     System.out.print(message);
    //     return in.nextLine();
    // }

    // private User createUser() {
    //     String firstName = prompt("Имя: ");
    //     String lastName = prompt("Фамилия: ");
    //     String phone = prompt("Номер телефона: ");
    //     return new User(firstName, lastName, phone);
    // }
}
