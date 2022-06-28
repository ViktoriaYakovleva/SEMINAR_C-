//1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


// int[] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void SumResult(int[] array){
//     int resultA = 0;
//     int resultB = 0;

//     for (int i = 0; i < 12; i++)
//     {
//         if (array[i] < 0 )
//         {
//             resultA += array[i]; 
//         }
//         else
//         {
//             resultB += array[i];
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Сумма отрицательных чисел = {resultA}");
//     Console.WriteLine($"Сумма положительных чисел = {resultB}");
// }

// void ShowArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + "  ");
//     }
// }

// int[] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);
// SumResult(myArray);



// 2.Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


int[] CreateRandomArray(int size, int min, int max){
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите количество элементов: ");
int S = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateRandomArray(S, m, M);

ShowArray(newArray);

for (int i = 0; i < S; i++)
{
    newArray[i] *= -1; 
}

ShowArray(newArray);




// 3. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int[] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + "  ");
//     }
//     Console.WriteLine();
// }

// void ProductMassiv(int[] array){
//     int result = 1;
//     int length = array.Length / 2;
//    for (int i = 0; i <= length; i++)
//    {
//     result = array[i] * array[array.Length - 1 - i];
//     Console.WriteLine(result);
//    } 
// }

// Console.WriteLine("Введите количество элементов: ");
// int S = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальный элемент: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный элемент: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[] newArray = CreateRandomArray(S, m, M);

// ShowArray(newArray);
// ProductMassiv(newArray);