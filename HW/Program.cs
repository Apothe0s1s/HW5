// Home Work.

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int[] array = new int[4];
// int Count = 0;
// for (int i = 0; i < 4; i++)
// {
//     array[i] = new Random().Next(100, 1000);
//     Console.Write($"{array[i]} ");
//     {
//     if(array[i]%2==0)
//     Count++;
//     }
// }
// Console.WriteLine("Количество чётных чисел " + Count);



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = new int[5];
// int sum = 0;
// for (int i = 0; i < 5; i++)
// {
//     array[i] = new Random().Next(100, 1000);
//     Console.Write($"{array[i]} ");
//     if(i%2==0)
//     sum += array[i];
// }
// Console.WriteLine("Сумма = " +sum);

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// int[] arr = new int[6];
//  for (int i = 0; i < arr.Length; i++)
// {
// arr[i] = new Random().Next(100, 1000);
// Console.Write(arr[i] + " ");
// }
// var max = arr[0];
// var min = arr[0];
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] < min) min = arr[i];
//     if (arr[i] > max) max = arr[i];
// }
            
// Console.WriteLine("Разность = " + (max - min));