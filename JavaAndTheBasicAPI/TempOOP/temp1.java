// package TempOOP;

// import java.util.List;
// import java.util.Optional;

// import notebook.model.User;

// public class temp1 {
//     @Override
//     public Optional<User> findById(Long id) {
//         return Optional.empty();
//     }

//     @Override
//     public Optional<User> update(Long userId, User update) {
//         List<User> users = findAll();
//         User editUser = users.stream()
//                 .filter(u -> u.getId()
//                         .equals(userId))
//                 .findFirst().orElseThrow(() -> new RuntimeException("User not found"));
//         editUser.setFirstName(update.getFirstName());
//         editUser.setLastName(update.getLastName());
//         editUser.setPhone(update.getPhone());
//         write(users);
//         return Optional.of(update);
//     }
// }
// https://github.com/MickAny/gb-notebook.git
// https://github.com/JuliyaGavryushova/solid-principle-first-seminar.git