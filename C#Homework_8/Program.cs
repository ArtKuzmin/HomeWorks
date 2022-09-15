/*
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] Create2DArray()
{
    Console.Write("Input number of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input minimal value of array: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input maximum value of array: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minVal, maxVal);
    return array;
}
void Print2DArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] SortArray(int[,] arr)
{
    int min = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1)-1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    min = arr[i, k];
                    arr[i, k] = arr[i, k + 1];
                    arr[i, k + 1] = min;
                }
            }
        }
    }
    return arr;
}

int[,] randArray = Create2DArray();
Print2DArray(randArray);
SortArray(randArray);
Print2DArray(randArray);
*/

/*
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] Create2DArray()
{
    Console.Write("Input number of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input minimal value of array: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input maximum value of array: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minVal, maxVal);
    return array;
}
void Print2DArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MinSum(int[,] arr)
{
    int minSumRow = 0;
    int[] rowSums = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        minSumRow = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            minSumRow += arr[i, j];
        }
        rowSums[i] = minSumRow;
    }
    int indexMinSum = 0; // По-хорошему бы в этом месте разбить на два метода
    for (int i = 1; i < rowSums.Length - 1; i++)
    {
        if (rowSums[i] < rowSums[indexMinSum])
            indexMinSum = i;
    }
    Console.WriteLine($"Number of row with the minimal sum of it's elements is {indexMinSum + 1}");
}

int[,] randArray = Create2DArray();
Print2DArray(randArray);
MinSum(randArray);
*/

/*
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] Create2DArray()
{
    Console.Write("Input number of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input minimal value of array: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input maximum value of array: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minVal, maxVal);
    return array;
}
void Print2DArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MultiplyMatrix(int[,] arrOne, int[,] arrTwo)
{
    if (arrOne.GetLength(1) == arrTwo.GetLength(0))
    {
        int[,] arrMult = new int[arrOne.GetLength(0), arrTwo.GetLength(1)];
        for (int i = 0; i < arrOne.GetLength(0); i++)
        {
            for (int j = 0; j < arrOne.GetLength(1); j++)
            {
                for (int k = 0; k < arrOne.GetLength(0); k++)
                    arrMult[i, j] += arrOne[i, k] * arrTwo[k, j];
            }
        }
        Print2DArray(arrMult);
    }
    else Console.WriteLine("Matrix One can not be multiplied by Matrix Two");
}

int[,] arrOne = Create2DArray();
Print2DArray(arrOne);
int[,] arrTwo = Create2DArray();
Print2DArray(arrTwo);
MultiplyMatrix(arrOne, arrTwo);
*/



//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить 
//массив, добавляя индексы каждого элемента.


// Напишите программу, которая заполнит спирально массив 4 на 4.