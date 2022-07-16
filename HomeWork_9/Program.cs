// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int SumNum(int M, int N)
// {
//     // if(N == 1) return 1;
//     if(M > N) return 0;
//     return M + SumNum(M + 1, N);
// }
// Console.WriteLine("Введите первое число:");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine(SumNum(m, n));



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


int AckermannFunc(int n, int m) {
    if (n == 0)
    return m + 1;
    else if (n != 0 && m == 0)
    return AckermannFunc(n - 1, 1);
    else
    return AckermannFunc(n - 1, AckermannFunc(n, m - 1));
}

Console.WriteLine("Введите первое число:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int m = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine(AckermannFunc(n, m));