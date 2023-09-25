/*
Напишите программу, которая на вход принимает число N
и выдает произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

int GetNumber(string message)
{
    Console.Write($"Введите число {message}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}
int GetMultipaer(int num)
{
    int result = 1;
    for(int i = 1; i <= num; i++)
    {
        result = result * i; 
    }
    return result;
}
int num = GetNumber(" ");
int mul = GetMultipaer(num);
Console.WriteLine(mul);
