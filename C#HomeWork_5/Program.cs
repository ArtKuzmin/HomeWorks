//Во всех задачах добавлял метод для вывода самого массива, чтобы можно было проверить правильность расчета основного задания

//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateArray(int n, int minValue, int maxValue)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("\b\b]");
    Console.WriteLine();
}
int FindEvenAmount(int[] array)
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            amount++;
    }
    return amount;
}
Console.Write("Input length of array:");
int l = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimal value of array:");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum value of array:");
int maxVal = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(l, minVal, maxVal);
int amount = FindEvenAmount(arr);

PrintArray(arr);
Console.Write($"Amount of even elements of array is {amount}");

*/

/*
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateArray(int n, int minValue, int maxValue)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("\b\b]");
    Console.WriteLine();
}

int FindOddSum(int[] array)
{
    int res = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        res += array[i];
    }
    return res;
}

Console.Write("Input length of array:");
int l = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimal value of array:");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum value of array:");
int maxVal = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(l, minVal, maxVal);
int sum = FindOddSum(arr);

PrintArray(arr);
Console.Write($"Sum of odd indices of array is {sum}");

*/

/*
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


double[] CreateArray(int n, int minValue, int maxValue)
{
    double[] array = new double[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble(); 
    }
    return array;
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

double FindMinMaxDif(double[] array)
{
    double res = 0;
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }

        if (array[i] > max)
        {
            max = array[i];
        }
    }
    res = max - min;
    return res;
}

Console.Write("Input length of array:");
int l = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimal value of array:");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum value of array:");
int maxVal = Convert.ToInt32(Console.ReadLine());

double[] arr = CreateArray(l, minVal, maxVal);
double dif = FindMinMaxDif(arr);

PrintArray(arr);
Console.Write($"Subtraction of max and min element of array is {dif}");

*/