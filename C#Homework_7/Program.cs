/*
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] Create2DArray()
{
    Console.Write("Input number of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input minimal value of array: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input maximum value of array: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)    
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(minVal, maxVal) + new Random().NextDouble();    
    return array;
}
void Print2DArray(double[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();   
    }    
    Console.WriteLine();
}
Print2DArray (Create2DArray());
*/




//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.




//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

