// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
// чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] FillArrayWithRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
Console.WriteLine("Введите числа M: ");
Console.WriteLine();
FillArrayWithRandom(array);
Console.Write(string.Join(", ", array));
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
    {
        count++;
    }
}
Console.Write(" Чисел меньше нуля -> " + count);