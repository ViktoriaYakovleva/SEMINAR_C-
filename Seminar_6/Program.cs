// 1. Перевернуть массив

// int[] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
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
//     Console.WriteLine();
// }
// int n = new Random().Next(2, 10);
// int[] A = CreateRandomArray(n, 0, 10);
// ShowArray(A);

// int[] B = new int[n];
//     for (int i = 0, j = n - 1; i < n; i++, j--)
//     {
//             B[i] = A[j];
//     }

// ShowArray(B);



//Написать программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник
// со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
bool IsTriangleExist(int A, int B, int C){
    if (A < B + C && B < A + C && C < A + B)
    {
        return true;
    }
    else 
        return false;
}
Console.WriteLine("Введите длину первой стороны");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину второй стороны");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину третьей стороны");
int c = Convert.ToInt32(Console.ReadLine());
if (IsTriangleExist(a, b, c))
{
   Console.WriteLine("Треугольник с такими сторонами существует"); 
}
else  
Console.WriteLine("Треугольник с такими сторонами не существует");