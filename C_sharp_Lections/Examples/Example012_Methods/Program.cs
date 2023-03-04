// Вид 1 (ничего не принимают, ничего не возвращают)
// void Method1()
// {
//     Console.WriteLine("Автор Лёша");
// }
// Method1();

// Вид 2 (принимают, не возвращают)
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");
// Method2(msg: "Текст сообщения2");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i ++;
//     }
// }
// Method21("Текст", 4);
// Method21(msg: "Текст2", count: 4);

// Вид 3: не принимает, но возвращает
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// Вид 4: принимает и возвращает
// string Method4(int count, string text) 
// {
//     int i = 0;
//     string result = string.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "asdf");
// Console.WriteLine(res);

// string Method4(int count, string text)
// {
//     string result = string.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);

// for (int i = 2; i<=10; i++)
// {
//     for (int j=2; j<=6; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }
string text = " — Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";