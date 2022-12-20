// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите переменную a ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите переменную b ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите переменную c ");
int c = Convert.ToInt32(Console.ReadLine());

if (a >= b && c < a)
{
    Console.Write("max = "); 
    Console.WriteLine(a);
}
else if (b >= a && c < b)
{
    Console.Write("max = ");
    Console.WriteLine(b);
}
else if (c >= a && b < c)
{
    Console.Write("max = ");
    Console.WriteLine(c);
}
else
{
    Console.WriteLine("Неверное значение");
}