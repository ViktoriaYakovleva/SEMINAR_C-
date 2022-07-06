// №1
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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
// int[,] ModifiedArray(int[,] originalArray)
// {
//     int lastRowInArray = originalArray.GetLength(0) - 1;
//     for (int i = 0; i < originalArray.GetLength(1); i++)
//     {
//         int temp = originalArray[0, i];
//         originalArray[0, i] = originalArray[lastRowInArray, i];
//         originalArray[lastRowInArray, i] = temp;
//     }
//     return originalArray;
// }
// Console.Clear();
// Console.Write("Введите количество строк:");
// int R = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов:");
// int C = int.Parse(Console.ReadLine());

// int[,] MyArray = GetArray(R, C, 0, 10);
// PrintArray(MyArray);
// Console.WriteLine("-----------");

// PrintArray(ModifiedArray(MyArray));



// №2
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//  В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

int[,] ChangeArray(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        result[j,i] = array[i,j] 
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
Console.Clear();
Console.Write("Введите количество строк:");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов:");
int columns = int.Parse(Console.ReadLine());

if (rows != columns)
{
    Console.WriteLine("В данной матрице нельзя заменить элементы.");
}
else
{
    int[,] array = GetArray(rows, columns, 0, 10)
    PrintArray(array);
    Console.WriteLine();
    PrintArray(ChangeArray(array));
}