/* Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
в которой находится эта точка.*/

int GetNumber(string message)
{
    Console.Write($"Введите число {message}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int numX = GetNumber("X");
int numY = GetNumber("Y");

Console.WriteLine($"X = {numX} ; Y = {numY}");

{
    if (numX > 0 && numY > 0)
    {
        Console.WriteLine("1 четверть");
    }
    else if (numX < 0 && numY > 0)
    {
        Console.WriteLine("2 четверть");
    }
        else if (numX < 0 && numY < 0)
    {
        Console.WriteLine("3 четверть");
    }
        else if (numX > 0 && numY < 0)
    {
        Console.WriteLine("4 четверть");
    }
    else if( numX == 0 || numY == 0)
    {
    Console.WriteLine("X или Y равно нулю");   
    }
}
