// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
// выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Выберите вариант решения ");
int task = Convert.ToInt32(Console.ReadLine());
int numb = new Random().Next(100, 1000);
Console.WriteLine("Ваше число " + numb);

switch (task)
{
    case 1:

    int A = ((numb/10) % 10);
    Console.WriteLine(A);
    break;

    case 2: 

    string index = numb.ToString();
    Console.WriteLine(index[1]);
    break;
}
  