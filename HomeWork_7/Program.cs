// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5   7    -2  -0,2
//  1  -3,3    8  -9,9
//  8   7,8  -7,1   9


// double[,] GetArray(int m, int n, int min, int max)
// {
//     double[,] result = new double[m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i,j] = new Random().NextDouble() * (max - min);
//         }
//     } 
//     return result;
// }
// void PrintArray(double[,] MyArray){
//     for (int i = 0; i < MyArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < MyArray.GetLength(1); j++)
//         {
//             Console.Write($"{MyArray[i,j]:f1} ");
//         }
//         Console.WriteLine();
//     }   
// }

// Console.Clear();
// Console.Write("Введите количество строк:");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов:");
// int columns = int.Parse(Console.ReadLine());

// double[,] MyArray = GetArray(rows, columns, 0, 10);
// PrintArray(MyArray);



// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет


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
// bool FindElement(int[,] array, int el)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i,j] == el) return true;
//         }
//     }
//     return false;
// }

// Console.Clear();
// Console.Write("Введите количество строк:");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов:");
// int columns = int.Parse(Console.ReadLine());

// int[,] Array = GetArray(rows, columns, 0, 10);
// PrintArray(Array);

// Console.Write("Введите значение элемента:");
// int element = int.Parse(Console.ReadLine());

// if (FindElement(Array, element))
// {
//     Console.WriteLine("Такой элемент есть в массиве.");
// }
// else
// {
//     Console.WriteLine("Такого элемента нет в массиве.");
// }

// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(min, max + 1);
        }
    } 
    return result;
}
void PrintArray(int[,] MyArray){
    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            Console.Write($"{MyArray[i,j]} ");
        }
        Console.WriteLine();
    }   
}
double[] GetResultArray(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int column = 0; column < array.GetLength(1); column++)
    {
        double sum = 0;
        for (int row = 0; row < array.GetLength(0); row++)
        {
            sum += array[row, column];
        }
        result[column] = Math.Round(sum / array.GetLength(0), 2);
    }
    return result;
}

Console.Clear();

Console.Write("Введите количество строк:");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов:");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

double[] averageColumns = GetResultArray(array);
Console.WriteLine($"Среднее арифметическое каждого столбца = {String.Join(";",averageColumns)}");
