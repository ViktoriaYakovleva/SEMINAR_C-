// 1. *Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// void PalindromNum(int n){
//     if (n < 10000 || n > 99999){
//     Console.WriteLine("Число не корректное, введите заново");    
//     }
//     if (n >= 10000 && n <= 99999){
//     int a1 = n % 10;
//     int a2 = n / 10 % 10;
//     int a3 = n / 100 % 10;
//     int a4 = n / 1000 % 10;
//     int a5 = n / 10000;
//     int x = a1 * 10000 + a2 * 1000 + a3 * 100 + a4 * 10 + a5;
//     if (n == x){
//         Console.WriteLine("Число " + n + " является палиндромом");
//     }
//     else {
//         Console.WriteLine("Число " + n + " не палиндром");
//     }}
// }
// Console.Write("Напишите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// PalindromNum(num);



// *2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// void DistPoints(int x1, int y1, int x2, int y2, int z1, int z2){
//     double dist = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
//     Console.WriteLine("A(" + x1 + "," + y1 + "," + z1 + "); B(" + x2 + "," + y2 + "," + z2 + ") -> " + dist);
// }
// Console.WriteLine("Введите координаты первой точки: ");
// int Ax = Convert.ToInt32(Console.ReadLine());
// int Ay = Convert.ToInt32(Console.ReadLine());
// int Az = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты второй точки: ");
// int Bx = Convert.ToInt32(Console.ReadLine());
// int By = Convert.ToInt32(Console.ReadLine());
// int Bz = Convert.ToInt32(Console.ReadLine());
// DistPoints(Ax, Ay, Az, Bx, By, Bz); 




// 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void CubeNum(int n){
//     int current = 1;
//     Console.Write(n + " -> ");
//     while (current <= n){
//         Console.Write(current * current * current + ", ");
//         current++;
//     }
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// CubeNum(num);
