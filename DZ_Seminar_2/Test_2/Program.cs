// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число ");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb < 99)
{
    Console.WriteLine("Введите трехзначное число ");
}

else
{
    Console.WriteLine("Выберите вариант решения: 1 или 2 ");
    int task = Convert.ToInt32(Console.ReadLine());
    
    switch (task)
    {
        case 1:

            int C = numb % 10;
            Console.WriteLine("последнне число " + C);

            break;

        case 2:

            string index = numb.ToString();
            Console.WriteLine("Последнее число " + index[2]);

            break;
    }
}
