/*
// 1. Напишите программу, которая на вход принимает число и выдает его квадрат (число, умноженное на само себя).
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num * num;
Console.WriteLine("Result is " + result);
*/

// // 2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

// Console.Write("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int square = num2 * num2;
// if (num1 == square)
// {
//     Console.Write("First number is a square of second number");
// }
// else
// {
//   Console.Write("First number is not a square of second number");  
// }

// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

// Console.Write("Input number of the day: ");
// int day = Convert.ToInt32(Console.ReadLine());
// if (day < 1 || day > 7)
// {
//     Console.Write("Incorrect number");
// }
// if (day == 1)
// {
//     Console.Write("Monday");
// }
// if (day == 2)
// {
//     Console.Write("Tuesday");
// }
// if (day == 3)
// {
//     Console.Write("Wednesday");
// }
// if (day == 4)
// {
//     Console.Write("Thursday");
// }
// if (day == 5)
// {
//     Console.Write("Friday");
// }
// if (day == 6)
// {
//     Console.Write("Saturday");
// }
// if (day == 7)
// {
//     Console.Write("Sunday");
// }

// // 4. Напишите программу, которая на входе принимает одно число (N), а на выходе показывает все целые числа от -N до N.

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int current = -1 * num;
// while (current <= num)
// {
//     Console.Write(current + " ");
//     current++;
// }

// // Второй вариант решения задачи :

//  Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int current = -1 * num+1;
// while (current < num)
// {
//     Console.Write(current + " ");
//     current++;
// }

// // 5. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа.

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int a = num % 10;
// Console.WriteLine(a);

// // Второй вариант решения задачи:
//  Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num >= 100 && num <= 999)
// {
//   int a = num % 10;
//   Console.WriteLine(a);
// }
// else
// {
//     Console.Write("Incorrect number");
// }