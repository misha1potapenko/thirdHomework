// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double distance (double ForDistanse)
{
    int x1 = Convert.ToInt32(Console.ReadLine());
    int y1 = Convert.ToInt32(Console.ReadLine());
    int z1 = Convert.ToInt32(Console.ReadLine());
    int[] PointFirst = new int[3];
    PointFirst[0] = x1;
    PointFirst[2] = y1;
    PointFirst[3] = z1;
    int x2 = Convert.ToInt32(Console.ReadLine());
    int y2 = Convert.ToInt32(Console.ReadLine());
    int z2 = Convert.ToInt32(Console.ReadLine());
    int[] PointSec = new int[3];
    PointSec[0] = x2;
    PointSec[2] = y2;
    PointSec[3] = z2;
    
}