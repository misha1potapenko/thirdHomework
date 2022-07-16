// Задача 19
// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int polydr(int ForNumber)
{

    
    int first = ForNumber / 10000 % 10;
    int five = ForNumber  % 10;
    int two = ForNumber /1000 % 10;
    int four = ForNumber / 10 % 10;
     

    if ((first == five) && (two == four))
    {
        Console.WriteLine("Число является палиндромом");
    }
    else if ((ForNumber / 100000 % 10) != 0)
    {
        Console.WriteLine("Число больше пятизначного");
    }
    else if ((ForNumber / 10000 % 10) == 0)
    {
        Console.WriteLine("Число меньше пятизначного");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
    return ForNumber;
        
}
polydr(number);