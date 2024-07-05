/*
Задание 4.
Представьте себе ситуацию: у нас есть группа студентов, и мы хотим отследить, 
кто из них посетил какие уроки и кто из преподавателей вёл данные уроки. 

Необходимо: 
1. Создать Map объект, который будет использоваться для хранения соответствия 
между уроком и преподавателем, урок => преподаватель.
2. Необходимо создать Map объект, ключами которого будут объекты студентов,
а значениями будут Set объекты, которые будут хранить уроки, посещенные 
студентом.
*/

const lessonsTeacher = new Map();
const studentLessons = new Map();

const ivan = {
    name: "Иван",
};

const pavel = {
    name: "Pavel",
};

const aleksey = {
    name: "Aleksey",
};

const ivanLessons = new Set();
const pavelLessons = new Set();

const lessonMath = "Математика";
const lessonRussian = "Русский язык";

const teacherMath = {
    name: "Paul",
};
const teacherRussian = {
    name: "Maxim",
};

ivanLessons.add(lessonMath);
ivanLessons.add(lessonRussian);

pavelLessons.add(lessonMath);

studentLessons.set(ivan, ivanLessons).set(pavel, pavelLessons);

studentLessons.set(aleksey, new Set([lessonMath, lessonRussian]));
lessonsTeacher.set(lessonMath, teacherMath).set(lessonRussian, teacherRussian);

console.log(studentLessons);

// Преподаватель по Математике: Смирнов.
console.log(`Преподаватель по математике: ${lessonsTeacher.get(lessonMath).name}`);
// Уроки Ивана: Математика, История.
console.log(`Уроки Ивана: ${[...studentLessons.get(ivan)].join(", ")}`);
