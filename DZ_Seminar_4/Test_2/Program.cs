// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число ");
int array = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (array > 0)
{
    int sun = array % 10;
    array /= 10;
    sum = sum + sun;
}
Console.WriteLine(sum);

