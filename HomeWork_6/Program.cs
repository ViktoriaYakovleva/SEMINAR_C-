// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// int[] CreateArray(int size){
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write("Введите " + i + " элемент:");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }
// int[] myArray = CreateArray(5);
// ShowArray(myArray);

// int count = 0;
// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] > 0)
//     {
//         count++; 
//         // return count;
//     } 
// }
// Console.Write($" -> {count}");


// Второй вариант:


// int count = 0;

// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0){
//         count++;
//     }
// }
// Console.WriteLine($" -> {count}");



// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.Write("Введите число:");
// int N = Convert.ToInt32(Console.ReadLine());


// string bin= Convert.ToString(N,2);
 
// Console.WriteLine(bin); 



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.Write("Введите k1: ");
// var k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b1: ");
// var b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k2: ");
// var k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2: ");
// var b2 = Convert.ToDouble(Console.ReadLine());
 
// x = b2 - b1 / k1 - k2;
// y =


// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

