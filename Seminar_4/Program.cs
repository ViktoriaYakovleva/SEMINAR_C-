// 1. Напишите программу, которая принимаеи на вход число А, выдает сумму чисел от 1 до А
// 7 -> 28; 4 -> 10; 8 -> 36/

// int SumNumber(int A){
//     int result = 0;
//     if (A >= 1){
//         for (int i = 1; i <= A; i++)
//         {
//            result = result + i; 
//         }
//         return result;
//     }
//     else return 0;
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// // Console.WriteLine(num + " -> " + SumNumber(num));
// Console.WriteLine($"{num} -> {SumNumber(num)}");


// 2. Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

// int AmountNumber(int num){
//     int count = 0;
//     while (num > 0)
//     {
//         num = num / 10;
//         count++;
//     }
//     return count;
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Количество цифр в числе: " + AmountNumber(number));



// 3. Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.

// int ProductNum(int N){
//     int current = 1;
//     if (N < 1) return 0;
//     else {
//         for (int i = 1; i <= N; i++)
//         {
//           current = current * i;  
//         }
//         return current;
//     }
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Произведение чисел = " + ProductNum(number));



// 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int[] CreateRandomArray(int size, int min, int max){
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int[] CreateArray(int size){
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите " + i + " элемент:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] myRandomArray = CreateRandomArray(8, 0, 1);
ShowArray(myRandomArray);

Console.WriteLine();

int[] myArray = CreateArray(5);
ShowArray(myArray);