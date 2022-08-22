// Task 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

1 2 4 7

2 3 5 9

2 4 4 8

int[,] CreateRandom2dArray (int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random(). Next(minValue, maxValue + 1);
        }

    }
    return newArray;
}


void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i , j]}");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] NewArray(int[,] array)
{
    int temp = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for (int r = 0; r < array.GetLength(1)- 1; r++)
            {
                if (array [i, r ] < array [ i, r + 1])
                {
                    temp = array[i, r];
                    array[i, r] = array[i, r + 1];
                    array[i, r + 1] = temp;
                }
            }
        }
    }
    return array;
}

Console.Write("Input the quantity of rows ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the quantity of columns ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the min value of the elements ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the max value of the elements ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


int[,] array = CreateRandom2dArray(row, col, min, max);
Print2dArray(array);
array = NewArray(array);
Print2dArray(array);
*/
// Task 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



int[,] CreateRandom2dArray (int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random(). Next(minValue, maxValue + 1);
        }

    }
    return newArray;
}

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i , j]}");
        Console.WriteLine();
    }
    Console.WriteLine();
}
void MinRows(int [,] array)
{
    int minsum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minsum += array[0,j];
    }
    Console.WriteLine($"Сумма строки  1 = {minsum}");
    int rows = 0;
    int sum = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Сумма строки {i + 1} = {sum} ");
        if (sum < minsum)
    {
        minsum = sum;
        rows = i;
    }
        sum = 0;
    }
    Console.WriteLine($" Строка с наименьшей суммой : {rows + 1}");
}
Console.Write("Input the quantity of rows ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the quantity of columns ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the min value of the elements ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the max value of the elements ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = CreateRandom2dArray(row, col, min, max);
Print2dArray(array);
MinRows(array);
*/

// Task 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
Например, заданы 2 массива:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

и

1 5 8 5

4 9 4 2

7 2 2 6

2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10

20 81 8 6

56 8 4 24

10 6 24 49

*/
/*
int[,] CreateRandom2dArray (int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random(). Next(minValue, maxValue + 1);
        }

    }
    return newArray;
}

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i , j]}" );
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] NewArray(int[,] array1, int [,] array2)
{
    int[,] newArray = new int [array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for ( int j = 0; j < array1.GetLength(1); j++)
        {
            newArray[i, j] = array1[i, j] * array2[i, j];
        }
    }
    return newArray;
}

Console.Write("Input the quantity of rows " );
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the quantity of columns " );
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the min value of the elements " );
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the max value of the elements " );
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array1 = CreateRandom2dArray(row, col, min, max);
int[,] array2 = CreateRandom2dArray(row, col, min, max);
Print2dArray(array1);
Print2dArray(array2);

int [,] newArray = NewArray( array1,  array2);
Print2dArray(newArray);

*/
// Task 4: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1)
*/
/*
int [,,] CreateRandom3dArray(int str, int rows, int columns, int minValue, int maxValue)
{
    int[,,] newArray = new int [ str, rows, columns];
    for ( int i = 0; i < str; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            for ( int k = 0; k < columns; k++)
            {
                newArray[i, j, k] = new Random().Next(minValue, maxValue + 1);

            }
        }
   }
   return newArray;
}


void Print3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for ( int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($" {array[i, j, k]} ({i}, {j}, {k}) ") ;

            }
            Console.WriteLine();

    
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}

int[,,] newArray = CreateRandom3dArray(2, 2, 2, 10, 99);
Print3dArray(newArray);

*/

// Task 5:  Заполните спирально массив 4 на 4.
/*
Например, на выходе получается вот такой массив:

1 2 3 4

12 13 14 5

11 16 15 6

10 9 8 7
*/

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i , j]}" );
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] NewArray(int rows, int columns)
{
    int[,] newArray = new int[ rows, columns];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= newArray.GetLength(0) * newArray.GetLength(1))
    {
        newArray[i, j] = temp;
        temp++;
        if ( i <= j + 1 && i + j < newArray.GetLength(0) - 1)
        j++;
        else if (i < j && i + j >= newArray.GetLength(1) - 1)
        i++;
        else if (i >= j && i + j > newArray.GetLength(0) - 1)
        j--;
        else 
        i--;
    }
    return newArray;
}


int[,] array = NewArray(5, 5);
Print2dArray(array);


