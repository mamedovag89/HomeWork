// Task 1:  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int[] newArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
         Console.Write($"Input number{i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
         Console.Write(array[i]+ " ");
     Console.WriteLine();
}

int Check(int[] array)
{ 
    int result = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            result = result + 1;

    return result;        
}

Console.Write(" input size array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = newArray(size);

int result = Check(array);
ShowArray(array);
Console.WriteLine($"{result} чисел больше 0");



// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//  b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
/*

Console.Write(" Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write(" Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write(" Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write(" Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2- b1) / (k1 - k2);
double y = k1 * x + b1;
Console.Write($" Точка пересечения { x};{ y} ");

*/