// Задача 23
// Напишите программу, которая принимает
//  на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Write("Введите число: ");
int NumberCube = Convert.ToInt32(Console.ReadLine());
// double count = Math.Pow(NumberCube,3);
// Console.WriteLine(count);
void ForNumberCube(int Number)
{
    double count = 1;
    double NumberCount = 1;
    while (count <= Number)
    {
        NumberCount = Math.Pow(count,3);
        Console.Write($"{NumberCount}, ");
        count++;

    }
}

ForNumberCube(NumberCube);
