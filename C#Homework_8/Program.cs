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


/*
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить 
//массив, добавляя индексы каждого элемента.

void Create3DArray()
{
    Console.Write("Input value of 3rd dimension length: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of rows: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int l = Convert.ToInt32(Console.ReadLine());
    int[,,] array = new int[m, n, l];
    if (array.GetLength(0) * array.GetLength(1) * array.GetLength(2) < 90)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    array[i, j, k] = UniqueNumber();
                }
        Print3DArray(array);
    }
    else Console.WriteLine("Array has more than 90 elements, it cannot be filled with unique 2 digit numbers");
}
void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        Console.Write("-----------"); // так разделяются "слои" массива
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + " ");
            }
        }
    }
    Console.WriteLine();

}
int UniqueNumber() 
{
    int rnd = new Random().Next(0, 90);
    int uniqueRand = 0;
    int[] twoDigitArr = new int[90];
    twoDigitArr[0] = 9;
    bool[] checkArr = new bool[90];
    for (int i = 0; i < 90; i++)
        twoDigitArr[i] = i + 10;
    uniqueRand = twoDigitArr[rnd];
    checkArr[rnd] = true;
    if (checkArr[rnd])
    {
        while (checkArr[rnd])
        {
            int rnd2 = new Random().Next(0, 90);
            uniqueRand = twoDigitArr[rnd2];
            if (!checkArr[rnd2])
            {
                checkArr[rnd2] = true;
                break;
            }
        }
    }
    else checkArr[rnd] = true;
    return uniqueRand;
}
Create3DArray();
*/


/*
// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] Create2DArray()
{
    Console.Write("Input number of rows and columns: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m, m];
    int count = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            array[i, j] = j + 1; // Не понимаю, почему при подстановке именно в этот цикл count + 1 вместо j + 1 после первой строки к переменной добавляется 21.
            count = array[i, j];
        }
        for (int j = 1; j < array.GetLength(0); j++)
        {
            array[j, i] = count + 1;
            count = array[j, i];
        }
    }
    for (int i = array.GetLength(0) - 1; i >= array.GetLength(0) - 1; i--)
    {
        for (int j = array.GetLength(0) - 2; j >= 0; j--)
        {
            array[i, j] = count + 1;
            count = array[i, j];
        }
        for (int j = array.GetLength(0) - 2; j > 0; j--)
        {
            array[j, 0] = count + 1;
            count = array[j, 0];
        }
    }
    for (int i = 1; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 1; j < array.GetLength(0) - 1; j++)
        {
            array[i, j] = count + 1;
            count = array[i, j];
        }
        for (int j = array.GetLength(0) - 2; j < array.GetLength(0) - 2; j++)
        {
            array[j, array.GetLength(0) - 2] = count + 1;
            count = array[j, i];
        }
    }
    return array;
}
void Print2DArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
                Console.Write("0" + array[i, j] + " ");
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] arr = Create2DArray();
Print2DArray(arr);
*/