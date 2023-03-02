// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

// void EvenNumbers(int[] array)
// {
//     int countEven = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             countEven++;
//         }
//     }
//     Console.WriteLine($"The number of even numbers in the array = {countEven}");
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);
// EvenNumbers(myArray);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

// void EvenNumbers(int[] array)
// {
//     int countEven = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 == 1)
//         {
//             countEven += array[i];
//         }
//     }
//     Console.WriteLine($"The number of even numbers in the array = {countEven}");
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);
// EvenNumbers(myArray);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// double[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     double[] array = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = Convert.ToDouble (new Random().Next(minValue, maxValue)) / 10;
//     }
//     return array;
// }

// void ShowArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void DifferenceMinMax(double[] array)
// {
//     double minValue = array[0];
//     double maxValue = array[0];
    
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > maxValue)
//         {
//             maxValue = array[i];
//         }
//     if (array[i] < minValue)
//         {
//             minValue = array[i];
//         }
//     }
//     Console.WriteLine($"Total {array.Length} numbers. Maximum value = {maxValue}, minimum value = {minValue}");
//     Console.WriteLine($"The difference between the maximum and minimum value = {maxValue - minValue}");
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// double[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// DifferenceMinMax(myArray);