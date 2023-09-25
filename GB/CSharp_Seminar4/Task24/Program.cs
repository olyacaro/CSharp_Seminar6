﻿/* Напишите программу, которая принимает на вход число (А)
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

/* Оператор инкремента ++ увеличивает операнд на 1. 
Операндом должна быть переменная, свойство или индексатор. 
Оператор инкремента поддерживается в двух формах: 
постфиксный оператор инкремента ( x++ ) 
и префиксный оператор инкремента ( ++x )*/

int num2 = 5;//num2 = 5

int num3 = num2++; // num3 присваиваем значение num2= 5; num2 = 6. Cначала в num2 возвращается число num (то есть 5) и ++ это +1 итого =6;
Console.WriteLine($"num3 = {num3} num2 = {num2}");

int num4 = ++num2; //num2 (уже = 6) +1 = 7; затем к num4 присваиваем эту 7. Сначала происходит прибавление к числу, а потом получаем результат.
Console.WriteLine($"num4 = {num4} num2 = {num4}");