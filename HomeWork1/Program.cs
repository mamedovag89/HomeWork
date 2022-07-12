// Task 1: Напишите программу, которая на вход  принимает два числа и выдает, какое число большее,а какое меньшее.

/*
Console.Write("input first integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Max number: " + a);
    Console.WriteLine("min number: " + b);
}
else
{
    Console.WriteLine("max number: " + b);
    Console.WriteLine("min number  " + a); 
}
*/

 // Task 2: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
/*
int a ;
int b ;
int c ;
int max = 0;

Console.Write("input first integer number: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("input third integer number: ");
c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    max = a;
}
else
{
    max = b;
}

if (max < c ) 
{
    max = c;
}

Console.Write("Maxsimum number " +  max);
*/
// Task 3: Напишите программу, которая на вход принимает число и выдает, является ли число четным.
/*
Console.WriteLine("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0) Console.Write("Число четное");

else Console.Write("Число нечетное");
*/
// Task 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;



while(current <= num)
{
    if(current % 2 == 0)
        Console.Write(current + " ");
    current++;
}
