/* Напишите программу, которая принимает на вход число (А)
и выдает сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

//Получаем число от юзера далее принимаем от юзира стрингу и парсим стрингу и возвращаем наш int.
using System.ComponentModel.DataAnnotations;

int GetNumber(string message)
{
    Console.Write($"Введите число {message}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int GetSum(int num) //принмаем число
{
    int sum = 0; // получаем сумму
    
    for(int i = 1; i <= num; i++)
    {
        sum+=i; //+= это то же самое что sum = sum +i
    }
    return sum;
}

int numA = GetNumber("A"); // возвращаем сумму всех чисел от 1 до А
int sum = GetSum(numA);
Console.WriteLine($"sum = {sum}");