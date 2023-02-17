// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void CubeLine (int num)
// {
//     for (int i = 1; i <= num; i++)
//     {
//     Console.Write ($"{i} -> {Math.Pow(i, 3)} ");
//     }
// }

// Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// CubeLine (n);

// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.WriteLine("Input a five-digit number: ");
// string num = Console.ReadLine();
// int length = num.Length;
// if (length == 5)
// {
//     if (num[0] == num[4] && num[1] == num[3])
//     {
//         Console.WriteLine($"{num} a palindrome number");
//     }
//     else
//     {
//         Console.WriteLine($"{num} is not a palindrome number");
//     }
// }
// else
// {
//     Console.WriteLine($"ERROR: {num} is not a five-digit number");
// }

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindDistance (double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2)),2);
// }

// Console.WriteLine ("Input coordinate X for first point: ");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine ("Input coordinate Y for first point: ");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine ("Input coordinate Z for first point: ");
// double za = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine ("Input coordinate X for second point: ");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine ("Input coordinate Y for second point: ");
// double yb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine ("Input coordinate z for second point: ");
// double zb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance between our points -> {FindDistance(xa, ya, za, xb, yb, zb)}");