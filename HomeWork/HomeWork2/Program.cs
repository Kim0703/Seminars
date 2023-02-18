// Задача 13:
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int number = ReadInt("Input three digit number: ");
// int amount = number.ToString().Length;

// if (amount < 3 || amount > 3)
// {
//     Console.WriteLine("It's not a three digit number.");
// }
// else
// {
//     Console.WriteLine(InCenter(number));
// }

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int InCenter(int a)
// {
    
//     int result = ((a / 10) % 10);
//     return result;
// }

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// while (true)
// {
//     Console.WriteLine("Input three digit number: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     if (num < 0) num = -num;
//     if (num >= 100 && num <= 999)
//     {
//         Console.WriteLine($"Two digit of {num} is {num / 10 % 10}");
//         break;
//     }
//     else
//     {
//         Console.WriteLine($"{num} is not a three digit number");
//     }
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// while (true)
// {
//     Console.WriteLine("Input week day: ");
//     int day = Convert.ToInt32(Console.ReadLine());
//     if (day < 1 || day > 7)
//     {
//         Console.WriteLine("It's not day");
//     }
//     if (day <= 5 && day > 0)
//     {
//         Console.WriteLine("Work day:");
//         break;
//     }
//     if (day == 6 || day == 7)
//     {
//         Console.WriteLine("Weekend:");
//         break;
//     }
// }