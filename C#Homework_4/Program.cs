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