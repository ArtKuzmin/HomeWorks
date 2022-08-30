/*
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int ToPower(int a, int b)
{
    int pow = a;
    for (int i = 1; i < b; i++)
        pow *= a;
    return pow;
}
Console.Write("Input integer A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer B: ");
int b = Convert.ToInt32(Console.ReadLine());
int pow = ToPower(a, b);
Console.Write($"{a} в степени {b} равняется {pow}");
*/

/*
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int FindIndex(int number)
{
    int result = number;
    int index = 0;
    for (int i = 0; result >= 1; i++)
    {
        result = result / 10;
        index++;
    }
    return index;
}
int isNumberPalindrom(int index, int number)
{
    int sum = 0;
    for (int i = 1; i <= index; i++)
    {
        sum += (int)((number % Math.Pow(10, i)) / Math.Pow(10, i - 1));
    }
    return sum;
}
Console.Write("Input integer: ");
int numIn = Convert.ToInt32(Console.ReadLine());
int index = FindIndex(numIn);
int sum = isNumberPalindrom(index, numIn);
Console.Write(sum);
*/