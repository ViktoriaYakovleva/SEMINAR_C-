// // 1. Напишите программу, которая принимает два числа и выдает, какое число большее, а какое меньшее.

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2)
// {
//     Console.WriteLine("Первое число большее, второе меньшее");
// }
// else if (num1 < num2)
// {
//     Console.WriteLine("Второе число большее, первое меньшее");
// }
// else
// {
//     Console.WriteLine("Оба числа равны");
// }

// // 2. Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;
// if (num1 > max) max = num1;
// if (num2 > max) max = num2;
// if (num3 > max) max = num3;
// Console.Write("Максимальное число: ");
// Console.WriteLine(max);

// // 3. Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int a = num % 2;
// if (a == 0)
// {
// Console.WriteLine("Это число четное");
// }
// else
// {
//  Console.WriteLine("Это число не четное");   
// }

// // 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int current = 2;
// while (current <= num)
// {
//     Console.Write(current + " ");
//     current = current + 2;
// }