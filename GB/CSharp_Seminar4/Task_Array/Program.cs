/*
Напишите программу, которая выводит массив из 8 элементов,
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

int[] getRandomArray(int length = 8)
{
    int[] binary = new int[length];
    
    for(int i = 0; i < binary.Length; i++)
    {
        binary[i] = new Random().Next(0,2);
    }
    return binary;
}

int[] nums = getRandomArray();
Console.WriteLine(string.Join(' ', nums)); //string.Join - через пробел будут поочередно выведены все элементы массива.
