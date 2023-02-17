// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// 78 -> 8

// 12-> 2

// 85 -> 8

// void MaxDecimal (int num)
// {
//     int ed = num % 10;
//     int dec = num / 10;
//     if (ed < dec)
//     {
//         Console.WriteLine ($"Great digit of {num} -> {dec}");
//     }
//     else
//     {
//         Console.WriteLine ($"Great digit of {num} -> {ed}");
//     }
// }

// int num = new Random().Next(1, 99 + 1);

// MaxDecimal(num);

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46

// 782 -> 72

// 918 -> 98

// int DeleteDecimal(int num)
// {
//     int sot = num / 100;
//     int ed = num % 10;
//     return sot * 10 + ed;
// }

// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);

// // int result = DeleteDecimal(num);
// // Console.WriteLine(result);
// Console.WriteLine(DeleteDecimal(num));

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

// void Multiplicity723 (int num)
// {
//     if (num % 7 == 0 && num % 23 == 0)
//     {
//         Console.WriteLine($"{num} is a multiple of 7 and 23");
//     }
//     else
//     {
//         Console.WriteLine($"{num} is not a multiple of 7 and 23");
//     }
// }

// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Multiplicity723(num);


// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// void Multiplicity723 (double num1, double num2)
// {
//     if (num1 % num2 == 0)
//     {
//         Console.WriteLine($"{num1} multiple of {num2}");
//     }
//     else
//     {
//         Console.WriteLine($"the remainder of the division {num1} / {num2} is {num1 % num2}");

//     }
// }

// Console.WriteLine("Input first number: ");
// double num1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input second number: ");
// double num2 = Convert.ToDouble(Console.ReadLine());

// Multiplicity723(num1, num2);