//  1. Напишите программу, которая на вход принимает координаты точки (Х и Y), причем х не равно 0, и y не равно 0, и выдает номер четверти плоскости, в которой находится эта точка.

// void QuarterFind(int X, int Y){
//     if (X > 0 && Y > 0){
//         Console.WriteLine("Точка находится в первой четверти");
//     }
//     else if (X < 0 && Y > 0){
//         Console.WriteLine("Точка находится во второй четверти");
//     }
//     else if (X < 0 && Y < 0){
//         Console.WriteLine("Точка находится в третьей четверти");
//     }
//     else if (X > 0 && Y < 0){
//         Console.WriteLine("Точка находится в четвертой четверти");
//     }
//     else{
//         Console.WriteLine("Точка находится на осях, проверьте координаты.");
//     }
// }
// Console.Write("Введите координат Х: ");
// int X = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координат Y: ");
// int Y = Convert.ToInt32(Console.ReadLine());
// QuarterFind(X, Y);

// Второй вариант:

// int QuarterFind(int X, int Y){
//     if (X > 0 && Y > 0)
//       return 1;
//     else if (X < 0 && Y > 0)
//       return 2;
//     else if (X < 0 && Y < 0)
//       return 3;
//     else if (X > 0 && Y < 0)
//       return 4;
//     else
//       return 0;
// }
// Console.Write("Введите координат Х: ");
// int Xcoord = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координат Y: ");
// int Ycoord = Convert.ToInt32(Console.ReadLine());
// int result = QuarterFind(Xcoord, Ycoord);
// if (result == 0){
//     Console.WriteLine("Точка находится на осях, проверьте координаты.");
// }
// else{
//     Console.WriteLine("Номер четверти: " + result);
// }


// 2. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (X, Y).

// void RangePoints(int quarter){
// if (quarter == 1)
//     Console.WriteLine("X > 0, Y > 0");
// else if (quarter == 2){
//     Console.WriteLine("X < 0, Y > 0");    
// }
// else if (quarter == 3){
//     Console.WriteLine("X < 0, Y < 0");    
// }
// else if (quarter == 4){
//     Console.WriteLine("X > 0, Y < 0");    
// }
// else
//   Console.WriteLine("Невозможно определить диапазон возможных координат");  
// }
// Console.Write("Введите номер четверти: ");
// int q = Convert.ToInt32(Console.ReadLine());
// RangePoints(q);


// 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2Д пространстве.
//  А(3, 6); В(2, 1) -> 5, 09
//  A(7, -5); B(1, -1) -> 7, 21

// void DistPoints(int x1, int y1, int x2, int y2){
//     double dist = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
//     Console.WriteLine("A(" + x1 + "," + y1 + "); B(" + x2 + "," + y2 + ") -> " + dist);
// }

// Console.WriteLine("Введите координаты первой точки: ");
// int Ax = Convert.ToInt32(Console.ReadLine());
// int Ay = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты второй точки: ");
// int Bx = Convert.ToInt32(Console.ReadLine());
// int By = Convert.ToInt32(Console.ReadLine());
// DistPoints(Ax, Ay, Bx, By);



// 4. Напишите программу, которая на вход принимает число (N) и выдает таблицу квадратов чисел от 1 до N.
//  5 -> 1, 4, 9, 16, 25
//  2 -> 1, 4

// void SquareNumber(int num){
//     int count = 1;
//     Console.Write(num + "-> ");
//     while (count <= num)
//     {
//         Console.Write(count * count + ", ");
//         count++;
//     }
// }
// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// SquareNumber(N);