/*
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Как вариант, можно без использования массива в цикле сразу после запроса числа проверять 
//его на положительность и увеличивать или нет счетчик. Альтернативное решение закомментировано в коде


//int FindNumberPositive(int m) 
int FindNumberPositive(int[] array)
{
    int count = 0;
    //for (int i = 0; i < m; i++)
    for (int i = 0; i < array.Length; i++)
    {
        // Console.Write($"Input {i} number: ");
        // int a = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0)
        //if (a > 0)
            count++;
    }
    return count;
}

int[] CreateArray(int m)
{
    int[] array = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Input {i} number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
Console.Write("How many numbers do you want to input? ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(m);
//int count = FindNumberPositive(m);
int count = FindNumberPositive(arr);
Console.WriteLine($"QUantity of positive numbers is {count}");

*/

/*
//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[] FindIntersection(int b1, int k1, int b2, int k2)
{
    double[] arr = new double[2];
    double x = (double)(b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;
    arr[0] = x;
    arr[1] = y;
    return arr;
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("\b\b]");
    Console.WriteLine();
}
Console.Write("Input value of b1 ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input value of k1 ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input value of b2 ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input value of k2 ");
int k2 = Convert.ToInt32(Console.ReadLine());
double[] arr = FindIntersection(b1, k1, b2, k2);
PrintArray(arr);
*/