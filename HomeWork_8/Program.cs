// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i,j] = new Random().Next(min, max + 1);
//         }
//     } 
//     return result;
// }
// void PrintArray(int[,] MyArray){
//     for (int i = 0; i < MyArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < MyArray.GetLength(1); j++)
//         {
//             Console.Write($"{MyArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }   
// }
// void SelectionSort(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             int minPosition = j;
//             for (int k = j + 1; k < array.GetLength(1); k++)
//             {
//                 if (array[i,k] < array[i,minPosition])
//                 minPosition = k;
//             }
//             int temporary = array[i,j];
//             array[i,j] = array[i,minPosition];
//             array[i,minPosition] = temporary;
//         }
//     }
// }

// Console.Clear();

// Console.Write("Введите количество строк:");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов:");
// int columns = int.Parse(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// Console.WriteLine("------------");

// SelectionSort(array);
// PrintArray(array);




// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i,j] = new Random().Next(min, max + 1);
//         }
//     } 
//     return result;
// }
// void PrintArray(int[,] MyArray){
//     for (int i = 0; i < MyArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < MyArray.GetLength(1); j++)
//         {
//             Console.Write($"{MyArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }   
// }
// int[] SumResultArray(int[,] array)
// {
//     int[] result = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//        int sum = 0;
//        for (int j = 0; j < array.GetLength(1); j++)
//         {
//         sum += array[i,j];
//         }
//         result[i] = sum;
//     }
//     return result;
// }
// void MinMaxResult(int[] SumColumns){
//     int max = SumColumns[0];
//     int min = SumColumns[0];

//     for (int i = 0; i < SumColumns.Length; i++)
//     {
//         if (SumColumns[i] > max )
//         {
//             max = SumColumns[i]; 
//         }
//         else if (SumColumns[i] < min)
//         {
//             min = SumColumns[i];
//         }
//     }
//     Console.Write($"Максимальная сумма:{max}, Минимальная сумма:{min}");
// }

// Console.Clear();

// Console.Write("Введите количество строк:");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов:");
// int columns = int.Parse(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 5);
// PrintArray(array);

// Console.WriteLine("----------");

// int[] SumColumns = SumResultArray(array);
// Console.WriteLine($"{String.Join("; " , SumColumns)}");
// Console.WriteLine("----------");
// MinMaxResult(SumColumns);




// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.




// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.



// Задача 62: Заполните спирально массив 4 на 4.


// Дополнительно:
// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника