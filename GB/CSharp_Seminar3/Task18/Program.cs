/* Задача 18: Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).*/

int GetNumber(string message)
{
    Console.Write($"Введите номер четверти {message}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int num = GetNumber("");

Console.WriteLine($"Номер четверти = {num}");

{
    if (num == 1)
    {
        Console.WriteLine("X < 0 и Y < 0");
    }
    else if (num == 2)
    {
        Console.WriteLine("X < 0 и Y > 0");
    }
        else if (num == 3)
    {
        Console.WriteLine("X < 0 и Y < 0");
    }
        else if (num == 4)
    {
        Console.WriteLine("X > 0 и Y < 0");
    }
    else
    {
    Console.WriteLine("Четверть это от 1 до 4");   
    }
}
