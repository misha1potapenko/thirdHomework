// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



double distance (double ForDistanse)
{
    Console.Write("Введите x1: ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите y1: ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите z1: ");
    int z1 = Convert.ToInt32(Console.ReadLine());
    // int[] PointFirst = new int[3];
    // PointFirst[0] = x1;
    // PointFirst[2] = y1;
    // PointFirst[3] = z1;
    // Console.WriteLine("[{0}]", string.Join(", ", PointFirst));
    Console.Write("Введите x2: ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите y2: ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите z2: ");
    int z2 = Convert.ToInt32(Console.ReadLine());
    // int[] PointSec = new int[3];
    // PointSec[0] = x2;
    // PointSec[2] = y2;
    // PointSec[3] = z2;
    // Console.WriteLine("[{0}]", string.Join(", ", PointSec));
    ForDistanse = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));
    

    return ForDistanse;
}
Console.WriteLine($"Расстояние между двумя точками: {distance(1)}");
