// 1. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5;  782 -> 8;   918 -> 1.

// void MiddleDigit(int num){
//     if (num >= 100 && num <= 999){
//     int x = num / 10 % 10;
//     Console.WriteLine(num + " -> " + x);
//     }
//     else{
//     Console.Write("Не корректное число "); 
//     }
// }
// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// MiddleDigit(num);

// 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5; 78 -> третьей цифры нет; 32769 -> 7.

// void ThirdDigit(int num){
//     if (num < 100){
//     Console.Write("третьей цифры нет");
//     }
//     if (num >= 100 && num <= 999){
//     int x = num % 10;
//     Console.WriteLine(num + " -> " + x);
//     }
//     if (num >= 1000 && num <= 9999){
//     int x = num / 10 % 10;
//     Console.WriteLine(num + " -> " + x);
//     }
//     if (num >= 10000 && num <= 99999){
//     int x = num /100 % 10;
//     Console.WriteLine(num + " -> " + x);
//     }
//     if (num >= 100000 && num <= 999999){
//     int x = num /1000 % 10;
//     Console.WriteLine(num + " -> " + x);
//     }
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// ThirdDigit(num);


// 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//  6 -> да; 7 -> да; 1 -> нет.

// void WeekNumber(int day){
//  if (day < 1){
//     Console.Write("Такого дня не существует");
//  }
//   if (day > 7){
//     Console.Write("Такого дня не существует");
//   }
//  if (day >= 1 && day <= 5){
//     Console.Write(day + " -> не выходной");
//  }
//  if (day == 6){
//     Console.Write(day + " -> выходной, суббота");
//  }
//  if (day == 7){
//     Console.Write(day + " -> выходной, воскресенье");
//  }
// }
// Console.Write("Введите номер дня недели: ");
// int day = Convert.ToInt32(Console.ReadLine());
// WeekNumber(day);

// // Второй вариант

// void WeekNumber(int day){
//  if (day < 1 || day >7){
//     Console.Write("Такого дня не существует");
//  }
//  if (day >= 1 && day <= 5){
//     Console.Write(day + " -> не выходной");
//  }
//  if (day == 6 || day ==7){
//     Console.Write(day + " -> выходной");
//  }
// }
// Console.Write("Введите номер дня недели: ");
// int day = Convert.ToInt32(Console.ReadLine());
// WeekNumber(day);


// Дополнительные задачи:
// 1. Написать программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет; 46 -> нет; 161 -> да;

// void DivideNumber(int num)
// {
// if (num % 7 == 0 && num % 23 == 0){
//     Console.WriteLine(num + " -> да ");
//     }
// else{
//     Console.WriteLine(num + " -> нет ");
//     }
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// DivideNumber(num);


// 2. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да; -4, 16 -> да; 25, 5 -> да; 8, 9 -> нет;

// void SquareNumber(int num1, int num2){
//  if (num1 * num1 == num2 || num2 * num2 == num1){
//     Console.Write(num1 + ", " + num2 + " -> да");
//     }
//  else{
//     Console.Write(num1 + ", " + num2 + " -> нет");
//     }
// }
// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// SquareNumber(num1, num2);