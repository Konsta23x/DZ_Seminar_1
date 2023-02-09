// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
// элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


void SumMToN(int m, int n)
{
    Console.Write(SumNumber(n - 1, m));
}

int SumNumber(int n, int m)
{
    int sum = n;
    if (n == m)
    {
        return 0;
    }
    else
    {
        n++;
        sum = n + SumNumber(n, m);
        return sum;
    }

}

Console.WriteLine("Введите число n ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число m ");
int m = Convert.ToInt32(Console.ReadLine());
SumMToN(m, n);