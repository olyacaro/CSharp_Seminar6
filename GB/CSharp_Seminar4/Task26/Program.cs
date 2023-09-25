/* 
Напишите программу, которая принимает на вход число
и выдает количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

int num = GetNumber(" ");
int i = 0;
int GetNumber(string message)
{
    Console.Write($"Введите число {message}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}
for( ; num > 0; num/=10)
    {
        i++;
    }
Console.WriteLine("Количество цифр в числе " +i);
