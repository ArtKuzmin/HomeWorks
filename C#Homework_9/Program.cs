/*
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void NaturalSequence(int m, int n) // можно добавить дополниительный if  на случай ввода M > N, чтобы выводилась последовательность от N до M
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

/*
//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int NaturalSum(int m, int n)
{
    if (m <= n)
    {
        if (n > 0)
        {
            while (m < 0) m++;
            return m += NaturalSum(m + 1, n);
        }
        else return 0;
    }
    else return 0;
}

Console.Write("Input value of M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input value of N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NaturalSum(m, n));
*/

/*
//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return 0;
}

Console.Write("Input positive value of M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input positive value of N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akkerman(m, n));
*/