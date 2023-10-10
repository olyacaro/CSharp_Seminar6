﻿/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3 
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/
//f(n)=f(n-1) + f(n-2) - формула.

int n = 50;
long lastNumber = 1;
long firstNumber = 1;

for(int i = 3; i < n; i++)
{
    long nextNumber = lastNumber + firstNumber;
    Console.WriteLine(nextNumber);
    firstNumber = lastNumber;
    lastNumber = nextNumber;
}
