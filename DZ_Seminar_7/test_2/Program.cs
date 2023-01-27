// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7(ввод индексов) -> такого числа в массиве нет
// 1, 1 -> 9


void FillAraay1(int[,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
        }

    }
    Console.WriteLine();
}

void PrintArrayWithRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Console.WriteLine("Введите значение m");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение n");
// int n = Convert.ToInt32(Console.ReadLine());
int m = 3;
int n = 4;

int[,] matrix = new int[m, n];
FillAraay1(matrix, m, n);
PrintArrayWithRandom(matrix);

Console.WriteLine("Введите значение i");
int i= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение j");
int j = Convert.ToInt32(Console.ReadLine());

if (i > m && j > n)
{
    Console.WriteLine("такого числа в массиве нет");
}
else
{
    Console.WriteLine($" {i}, {j} ->  {matrix [i,j]}");
}