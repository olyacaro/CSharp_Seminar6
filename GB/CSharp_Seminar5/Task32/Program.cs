/* Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
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
void plusMinus(int[] array)
{
    for(int i= 0; i < array.Length; i++)
    {
        array[i] = array [i] * -1;
    }
}

int[] array = getRandomArray(4, -9, 9);
Console.WriteLine(string.Join(", ", array));
plusMinus(array);
Console.WriteLine(string.Join(", ", array));

