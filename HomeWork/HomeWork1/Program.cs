// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//     Console.WriteLine("num1, greater");
//     Console.WriteLine("num2, lesser");
// }
// if (num1 < num2)
// {
//     Console.WriteLine($"{num1} lesser");
//     Console.WriteLine($"{num2} greater");
// }
// if (num1 == num2)
// {
//     Console.WriteLine($"{num1} equal to {num2}");
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Input first number");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input third number");
// int c = Convert.ToInt32(Console.ReadLine());

// int max = a;

// if (b > max)
// {
//     max = b;
// }

// if (c > max)
// {
//     max = c;
// }
// Console.WriteLine($"Maximum number is {max}");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 == 0)
// {
//     Console.WriteLine("Even number");
// }
// else
// {
//     Console.WriteLine("Odd number");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// int res = 1;
// while (res < num)
// {
//     Console.WriteLine(res+1);
//     res+= 2;
// }    