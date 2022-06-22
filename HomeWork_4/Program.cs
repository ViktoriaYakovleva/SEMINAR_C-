// 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int DegreeNum(int A, int B){
//     int current = 1;
//     for (int i = 0; i < B; i++)
//     {
//     current = current * A; 
//     }
//     return current;
// }

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(num1 + ", " + num2 + " -> " + DegreeNum(num1, num2));




//2.  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumDigit(int N){
//     int sum = 0;
//     while(N > 0){
//         sum = sum + N % 10;
//         N = N / 10;
//     }
//     return sum;
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(num + " -> " + SumDigit(num));




// 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] CreateRandomArray(int size){
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//     }
//     return array;
// }

// void ShowArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + "  ");
//     }
// }

// int[] myRandomArray = CreateRandomArray(8);
// ShowArray(myRandomArray);
