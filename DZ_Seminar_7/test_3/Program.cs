// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void FillAraay1(int[,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(1, 50);
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

Console.WriteLine("Введите значение m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n");
int n = Convert.ToInt32(Console.ReadLine());

double sum = 0;
int stolb = -1;
int[,] matrix = new int[m, n];
FillAraay1(matrix, m, n);
PrintArrayWithRandom(matrix);

for (int j = 0; j < matrix.GetLength(1); j++)
{
    stolb++;
    sum= 0.0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum =  sum + matrix[i, j];

    }
    Console.WriteLine($"Среднее арифметическое столбца  {stolb} = {sum/m}");
}



