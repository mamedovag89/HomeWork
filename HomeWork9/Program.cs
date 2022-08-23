// Task 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""

void NumsMN(int m, int n)
{
    if (m > n )
    {
        int temp = n;
        n = m;
        m = temp;
    }
   if(n != m)
        NumsMN(m, n - 1);
        Console.Write(n + " ");
}
Console.Write("Input number N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number M: ");
int numM = Convert.ToInt32(Console.ReadLine());


NumsMN(numN, numM);

*/



// Task 2:  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

int SumMN(int m, int n)
{
    if (m > n)
    {
        int temp = m;
        m = n ;
        n = temp;
    }

    if (n != m) return n + SumMN(m, n - 1);
    return n;
}

Console.Write("Input number M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int numN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма натуральных чисел от {numM} до {numN} =  {SumMN(numM, numN)}");
*/
// Task 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
m = 2, n = 3 -> A(m,n) = 29
*/

int A(int n, int m)
{
    if (n == 0) return m + 1;
    else if ((n != 0) && (m == 0)) return A(n - 1, 1);
    else return A(n - 1, A(n, m - 1));
}
int a = A(3, 2);
Console.WriteLine(a);