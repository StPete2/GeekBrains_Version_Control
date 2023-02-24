Console.WriteLine("Пожалуйста, введите имя пользователя");
string UserName = Console.ReadLine();
if (UserName == "Маша")
{
    Console.WriteLine("Ура! Это же МАША!");
}
else
{
    Console.WriteLine("Привет, " + UserName);
}