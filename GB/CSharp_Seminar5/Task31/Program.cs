/* Задача 31: Задайте массив из 12 элементов, 
заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

int[] getRandomArray(int length, int min, int max)
{
    int[] array = new int[length];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int sumMin(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int sumMax(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int[] array = getRandomArray(12, -9, 9);
string str = string.Join(",", array);
Console.WriteLine(str);
int min = sumMin(array);
Console.WriteLine($"Сумма отрицательных = {min}");
int max = sumMax(array);
Console.WriteLine($"Сумма положительных = {max}");