// Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillAraay1(double[,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(1, 100)) / 10;
        }

    }
    Console.WriteLine();
}

void PrintArrayWithRandom(double[,] matrix)
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
double[,] matrix = new double[m, n];
FillAraay1(matrix, m, n);
PrintArrayWithRandom(matrix);
