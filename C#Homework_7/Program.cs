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
            array[i,j] = Math.Round ((new Random().Next(minVal, maxVal) + new Random().NextDouble()), 2);    
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

/*
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] Create2DArray()
{
    //создадим рандомный двухмерный массив с такимм параметрами, т.к. от пользователя мы по условию не спрашивам о массиве
    int m = new Random().Next(1, 20);
    int n = new Random().Next(1, 20);

    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 100);
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

String IsThereSuchIndex(int[,] randomArray, int i, int j)
{
    Print2DArray(randomArray);
    string result = string.Empty;
    if ((i+1) <= randomArray.GetLength(0) && (j+1) <= randomArray.GetLength(1))
        result = Convert.ToString(randomArray[i, j]);
    else
        result = "Такого элемента в массиве нет";
    return result;
}

Console.Write("Input number of row: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of column: ");
int j = Convert.ToInt32(Console.ReadLine());

string answer = IsThereSuchIndex(Create2DArray(), i, j);
Console.Write(answer);
*/
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

