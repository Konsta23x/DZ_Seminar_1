// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.

// [3.7; 7.2; 2.1; 7.8] -> 5.7

double[] FillArrayWithRandom(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(1, 100)) / 10;
    }
    return array;
}
Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = new double[length];
FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.Write('[' + string.Join(", ", array) + ']');

double MaxArray = 0;
double MinArray = 10;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > MaxArray)
    {
        MaxArray = array[i];
    }
}
for (int i = 0; i < array.Length; i++)
{
    if (MinArray > array[i] )
    {
        MinArray = array[i];
    }
}
double diff = Math.Round((MaxArray - MinArray) , 3);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным значением {MaxArray} и минимальным {MinArray} равна {diff}");
