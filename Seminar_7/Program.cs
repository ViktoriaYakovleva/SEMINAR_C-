// Задача из домашнего задания.
// Перевод числа из десятичной системы в двоичную.

// int ConvertDecBin(int num){
//     int BinNum = 0;
//     int count = 0;
//     while (num >= 1){
//     if (count == 0)
//         count = 1;
//     else
//         count = count * 10;
//     BinNum = BinNum + (num % 2) * count;
//     num = num / 2;
//     }
//     return BinNum;
// }
// Console.WriteLine("Введите число: ");
// int DecNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(DecNum + " -> " + ConvertDecBin(DecNum));



// Второй вариант:
// void ConvertDecBin(int num){
//     int BinNum = 0;
//     int count = 0;
//     while (num >= 1){
//         if (count == 0)
//             count = 1;
//         else
//             count = count * 10;
//         BinNum = BinNum + (num % 2) * count;
//         num = num / 2;
//         Console.WriteLine("num -> " + num);
//         Console.WriteLine("count -> " + count);

//     Console.WriteLine("------------");
//     Console.WriteLine("BinNum");
//     }
//     // return BinNum;
// }
// Console.WriteLine("Введите число: ");
// int DecNum = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine(DecNum + " -> " + ConvertDecBin(DecNum));

// ConvertDecBin(DecNum);



// Задача №2
// Задайте двумерный массив размером m*n, заполненный случайными целыми числами
// 1   4   8   19
// 5  -2   33  -2
// 77  3   8   1

// int[,] GetRandomArray(int m, int n, int min, int max)
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
// void PrintRandomArray(int[,] Arr){
//     for (int i = 0; i < Arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < Arr.GetLength(1); j++)
//         {
//             Console.Write($"{Arr[i,j]} ");
//         }
//         Console.WriteLine();
//     }   
// }
// Console.Clear();            //Команда для очищения терминала перед печатью программы
// Console.Write("Введите количество строк:");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов:");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальный диапазон:");
// int Min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальный диапазон:");
// int Max = Convert.ToInt32(Console.ReadLine());

// int[,] MyArray = GetRandomArray(M, N, Min, Max);
// PrintRandomArray(MyArray);


// Задача №3
// Задайте двумерный массив размером m*n, каждый элемент массива находится по формуле A = m+n
// m = 3
// n = 4
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


// int[,] GetArray(int m, int n)
// {
//     int[,] result = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i,j] = i + j;
//         }
//     } 
//     return result;
// }
// void PrintArray(int[,] Arr){
//     for (int i = 0; i < Arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < Arr.GetLength(1); j++)
//         {
//             Console.Write($"{Arr[i,j]} ");
//         }
//         Console.WriteLine();
//     }   
// }
// Console.Clear();            //Команда для очищения терминала перед печатью программы
// Console.Write("Введите количество строк:");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов:");
// int N = Convert.ToInt32(Console.ReadLine());

// int[,] MyArray = GetArray(M, N);
// PrintArray(MyArray);


// Задача №4
// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные,
//  и замените эти элементы на их квадраты.
// Например, изначальный массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


// int[,] GetRandomArray(int m, int n, int min, int max)
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
// void PrintRandomArray(int[,] Arr){
//     for (int i = 0; i < Arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < Arr.GetLength(1); j++)
//         {
//             Console.Write($"{Arr[i,j]} ");
//         }
//         Console.WriteLine();
//     }   
// }
// int[,] ChangeArray(int[,] Arr){
//     for (int i = 2; i < Arr.GetLength(0); i++)
//     {
//         for (int j = 2; j < Arr.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 Arr[i,j] = Arr[i,j] * Arr[i,j];
//             }
//         }
//     }
//     return Arr;
// }
// Console.Clear();            //Команда для очищения терминала перед печатью программы
// Console.Write("Введите количество строк:");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов:");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальный диапазон:");
// int Min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальный диапазон:");
// int Max = Convert.ToInt32(Console.ReadLine());

// int[,] MyArray = GetRandomArray(M, N, Min, Max);
// PrintRandomArray(MyArray);
// Console.WriteLine("-----------");

// int[,] MyChangeArray = ChangeArray(MyArray);
// PrintRandomArray(MyChangeArray);
