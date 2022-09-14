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

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


// .Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить 
//массив, добавляя индексы каждого элемента.


// Напишите программу, которая заполнит спирально массив 4 на 4.