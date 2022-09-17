/*
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void NaturalSequence(int m, int n)
{
    if (m <= n)
    {
        NaturalSequence(m, n - 1);
        Console.Write(n + " ");
    }
}

Console.Write("Input value of M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input value of N: ");
int n = Convert.ToInt32(Console.ReadLine());
NaturalSequence(m,n);
*/

//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.