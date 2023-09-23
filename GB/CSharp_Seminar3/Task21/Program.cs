/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 A (7,-5); 
B (1,-1) -> 7,21 */

int GetNumber(string message)
{
    Console.Write($"Введите координаты {message}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int numX1 = GetNumber("X1");
int numY1 = GetNumber("Y1");
int numX2 = GetNumber("X2");
int numY2 = GetNumber("Y2");

int numX = numX2 - numX1;
int numY = numY2 - numY1;

double distance = Math.Sqrt(Math.Pow(numX, 2) + Math.Pow(numY, 2));

Console.WriteLine(distance);
//Console.WriteLine(Math.Round(distance,2)); округляет координаты до сотых.