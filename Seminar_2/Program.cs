// // 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру.
// // 78 -> 8
// // 12 -> 2
// // 85 -> 8

// void showNumber(){
//     int num = new Random().Next(10, 100);
//     int num1 = num / 10;
//     int num2 = num % 10;
//     Console.Write(num + " -> ");
//     if(num1 > num2){
//         Console.WriteLine(num1);
//     }
//     else{
//         Console.WriteLine(num2);
//     }
// }
// showNumber();


// 2. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
//  456 -> 46
//  312 -> 32

// void showNumber(){
//     int num = new Random().Next(100, 1000);
//     int num1 = num / 100;
//     int num2 = num % 10;
//     int x = num1 * 10 + num2;
//     Console.Write(num + " -> ");
//     Console.WriteLine(x);
// }
// showNumber();

// // Второй вариант:

// void FirstLastDigit(){
//     int num = new Random().Next(100, 1000);
//     int num1 = num / 100 * 10 + num % 10;
    
//     Console.WriteLine(num + " -> " + num1);
// }
// FirstLastDigit();

// // 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно 1, то программа выводит остаток от деления.
// // 34, 5 -> не кратно, остаток 4
// // 16, 4 -> кратно

void DivideNumber(int num1, int num2)
{
if (num1 % num2 == 0){
    Console.WriteLine(num1 + ", " + num2 + " -> кратно ");
    }
else{
    int num3 = num1 % num2;
    Console.WriteLine(num1 + ", " + num2 + " -> не кратно, остаток " + num3);
    }
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
        
DivideNumber(num1, num2);
