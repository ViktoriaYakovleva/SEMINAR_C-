// 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int[] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }
// void EvenNumber(int[] array){
//     int count = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0 )
//         {
//             count++;
//         }
//     }
//     // Console.WriteLine();
//     Console.Write($" -> {count}");
// }

// void ShowArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ",  ");
//     }
// }

// int[] myArray = CreateRandomArray(6, 100, 1000);
// ShowArray(myArray);
// EvenNumber(myArray);




// 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
//  стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int[] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }
// void SumNumber(int[] array){
//     int sum = 0;
//     for (int i = 1; i < array.Length; i++)
//     { 
//         if (i % 2 == 1){
//             sum += array[i];
//         } 
//     }
//     // Console.WriteLine();
//     Console.Write($" -> {sum}");
// }

// void ShowArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ",  ");
//     }
// }

// int[] myArray = CreateRandomArray(6, -2, 11);
// ShowArray(myArray);
// SumNumber(myArray);



// 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


// int[] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }

// void ShowArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + "  ");
//     }
// }

// void DifferenceResult(int[] array){
//     int max = array[0];
//     int min = array[0];

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max )
//         {
//             max = array[i]; 
//         }
//         else if (array[i] < min)
//         {
//             min = array[i];
//         }
//     }
//     Console.Write($" -> ({max}) - ({min}) = {max - min}");
// }

// int[] myArray = CreateRandomArray(6, -2, 10);
// ShowArray(myArray);
// DifferenceResult(myArray);
