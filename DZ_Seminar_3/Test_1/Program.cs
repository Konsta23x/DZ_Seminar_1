// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число ");
int i = Convert.ToInt32(Console.ReadLine());
string index = i.ToString();

    if (index[0] == index[4] && index[1] == index[3])
        Console.WriteLine("Да ");
    
    else
        Console.WriteLine("Нет");

