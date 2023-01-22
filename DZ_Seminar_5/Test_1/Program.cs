// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] FillArrayWithRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.Write('[' + string.Join(", ", array) + ']');

int countPositive = 0;
int countNegative = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 > 0)
    {
        countNegative++;
    }
    else
    {
        countPositive++;
    }
}

Console.WriteLine();
Console.WriteLine($"Количество отрицательных чисел = {countNegative}, положительных чисел = {countPositive}");
