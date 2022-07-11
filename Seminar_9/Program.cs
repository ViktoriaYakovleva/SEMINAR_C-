// 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа от 1 до N.
// N = 5;  1,2,3,4,5
// string NumberList(int Start, int End)
// {
//     if (Start == End) return Start.ToString();
//     return $"{Start} {NumberList(Start + 1, End)}";
// }


// Console.WriteLine("Введите число:");
// int N = int.Parse(Console.ReadLine());
// Console.WriteLine(NumberList(1, N));

// или

// for (int i = 1; i <= N; i++)
// {
//     Console.Write($"{i} ");
// }

// 2.Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 3; N = 7; -> 3,4,5,6,7

// string NumberList(int Start, int End)
// {
//     if (Start == End) return Start.ToString();
//     return $"{Start} {NumberList(Start + 1, End)}";
// }

// Console.WriteLine("Введите первое число:");
// int M = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int N = int.Parse(Console.ReadLine());
// Console.WriteLine(NumberList(M, N));


// ИЛИ
// for (int i = M; i <= N; i++)
// {
//     Console.Write($"{i} ");
// }


// 3. Напишите программу, которая будет принимать число и возвращать сумму его цифр.
// 453 -> 12;

// int SumOfNumbers(int N)
// {
//     if(N == 0) return 0;
//     return N % 10 + SumOfNumbers(N / 10);
// }
// Console.WriteLine("Введите число:");
// int N = int.Parse(Console.ReadLine());
// Console.WriteLine(SumOfNumbers(N));

// ИЛИ

// void SumOfNumbers(int N)
// {
//     int sum = 0;
//     while (N > 0)
//     {
//       sum = sum + N % 10;
//       N = N / 10;  
//     }
//     Console.WriteLine(sum);
// }
// Console.WriteLine("Введите число:");
// int N = int.Parse(Console.ReadLine());
// SumOfNumbers(N);


// 4. Напишите программу, которая на вход принимает число A и B, и возводит число А в целую степень В.

int PowNum(int num, int rank)
{
    if(rank == 0) return 1;
    if(rank == 1) return num;
    return num * PowNum(num, rank - 1);
}
Console.WriteLine("Введите первое число:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int B = int.Parse(Console.ReadLine());

Console.WriteLine(PowNum(A, B));