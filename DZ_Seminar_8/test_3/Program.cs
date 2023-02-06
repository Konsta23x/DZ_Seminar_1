// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillAraay1(int[,,] matrix, int m, int n, int p)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < p; k++)
            {
                matrix[i, j, k] = new Random().Next(10, 100);

            }

        }

    }
    Console.WriteLine();
}

void PrintArrayWithRandom(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            Console.WriteLine();
            for (int K = 0; K < matrix.GetLength(2); K++)
            {
                Console.Write($"{matrix[i, j, K]} ({i} {j} {K}) \t");
            }
        }
        Console.WriteLine();
    }
    
}

int m = 2;
int n = 2;
int p = 2;
int[,,] matrix = new int[m, n, p];
FillAraay1(matrix, m, n, p);
PrintArrayWithRandom(matrix);