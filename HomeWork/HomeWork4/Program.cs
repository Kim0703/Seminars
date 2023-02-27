// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// int DegreeNumber(int A, int B)
// {
//     int result = A;
//     for (int i = 0; i < B -1; i++)
//     {
//         result *= A;
//     }
//     return result;
// }

// Console.WriteLine("Input A");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input B");
// int B = Convert.ToInt32(Console.ReadLine());

// void ShowDegree(int result)
// {
//     Console.Write($"Degree of a number {A} is {result}.");
// }

// ShowDegree(DegreeNumber(A, B));


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// int SumDigits(int number)
// {
//     int result = 0;
//     for (int i = 0; number > 0; i++)
//     {
//         result += number % 10;
//         number /= 10;
//     }
//     return result;
// }

// Console.WriteLine("Input number");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(SumDigits(number));


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int max = Convert.ToInt32(Console.ReadLine());

// //int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(CreateRandomArray(size, min, max));