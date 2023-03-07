int[] points = new int [2];

Console.WriteLine("Ввод координат Х и Y");
for (int i=0; i<points.Length; i++)
{
    points[i] = Convert.ToInt32(Console.ReadLine());
}
if (points[0]>0 && points[1]>0)
{
    Console.WriteLine("Это первая четверть");
}
else if (points[0]<0 && points[1]>0)
{
    Console.WriteLine("Это вторая четверть");
}
else if (points[0]<0 && points[1]<0)
{
    Console.WriteLine("Это третья четверть");
}
else if (points[0]>0 && points[1]<0)
{
    Console.WriteLine("Это четвертая четверть");
}
else
{
    Console.WriteLine("X && Y = 0");
}