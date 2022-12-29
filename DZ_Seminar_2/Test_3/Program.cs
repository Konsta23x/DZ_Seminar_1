// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите число от 1 до 7");
int dayNumber = Convert.ToInt32(Console.ReadLine());

    if (dayNumber> 0 && dayNumber < 8)
    {
        if (dayNumber == 7 || dayNumber == 6)
        {
            Console.Write(dayNumber + " Выходной!");
        }
        else
        {
            Console.Write(dayNumber + " Рабочий день");
        }
    }
    else
    {
        Console.Write("Такого дня в недели НЕТ!");
    }
