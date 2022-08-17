// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/
/*
double[,] CreateRandom2dArrayDouble (int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double [rows,columns];

    for(int i = 0; i < rows; i++)
    {
        for( int j = 0; j < columns; j++)
        {
         newArray[i, j] = new Random().Next(minValue, maxValue + 1)+ new Random().NextDouble();;
        }
     }
     return newArray;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++ )
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.Write(" Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input min possible value of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input max possible value  of array: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateRandom2dArrayDouble(m, n, min, max);
Show2dArray(array);

*/
/* Task 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет

*/


int[,] CreateRandom2dArray ( int rows, int columns)
{
    int[,] newArray = new int [rows,columns];

    for(int i = 0; i < rows; i++)
    {
        for( int j = 0; j < columns; j++)
        {
         newArray[i, j] = new Random().Next(1,10);
        }
     }
      return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0);i++ )
    {
        for (int j =0; j < array.GetLength(1); j++)
        {
            Console.WriteLine(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void FindElement(int [,]array , int row, int colum)
{
    if ( row < array.GetLength(0) && colum < array.GetLength(1))
        Console.Write(array[row , colum]);
        else Console.Write("Такого числа нет");
}

Console.Write(" Input number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input number of columns: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input the number of row to find: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input the number of column to find: ");
int n = Convert.ToInt32(Console.ReadLine());




int[,] newArray = CreateRandom2dArray (row,col );
Show2dArray(newArray);

FindElement(newArray, m, n);


/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
/*
int[,] CreateRandom2dArray ( int rows,int columns, int minValue, int maxValue)
{
    int[,] newArray = new int [rows,columns];

    for(int i = 0; i < rows; i++)
    {
        for( int j = 0; j < columns; j++)
        {
         newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
     }
      return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0);i++ )
    {
        for (int j =0; j < array.GetLength(1); j++)
        {
            Console.WriteLine(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void SumColumnsArray(int[,] array )
{
    double result;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0; 
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum+= array [i,j];
        }
        result = sum / array.GetLength(0);
        Console.WriteLine ($" Среднее арифметическое столбца {j} = {result}");

    }
}

Console.Write(" Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input min possible value of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input max possible value of array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(m, n, min, max);
Show2dArray(array);

SumColumnsArray(array);
*/