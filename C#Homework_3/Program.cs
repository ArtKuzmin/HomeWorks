/*
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
//Задача выполняется, но есть ворнинг, что в цикле есть недостижимый код. В каких случаях он недостижим, я так и не понял

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
void isNumberPalindrom(int index, int number)
{
    bool t = false;
    for (int i = 1; i < (1 + index / 2); i++)
    {
        if (number % Math.Pow(10, i) == (int)(number / Math.Pow(10, (index - 1))))
        {
            t = true;
            index--;
        }
        else t = false;
        break;
    }
    if (t == true) Console.Write($"Number {number} is palindrom");
    else Console.Write($"Number {number} is not palindrom");
}
Console.Write("Input integers: ");
int numIn = Convert.ToInt32(Console.ReadLine());
int index = FindIndex(numIn);
isNumberPalindrom(index, numIn);
*/

/*
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void ShowCubes(int number)
C
    for (int i =1; i <=number; i++)
    {
        Console.Write($" {i*i*i} ");
    }

}
Console.Write("Input integer: ");
int numIn = Convert.ToInt32(Console.ReadLine());
ShowCubes(numIn);

*/

/*
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double FindDistance(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double result = 0;
    double dX = xA - xB;
    double dY = yA - yB;
    double dZ = zA - zB;
    result = Math.Sqrt(dX * dX + dY * dY + dZ * dZ);
    return result;
}

Console.Write("Input X coordinate of A: "); // беглый гугл по паре ссылок не помог, но не сомневаюсь, что из метода ReadLine можно считывать несколько аргументов, что сильно сократит колличество строк кода:)
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y coordinate of A: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z coordinate of A: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input X coordinate of B: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y coordinate of B: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z coordinate of B: ");
double zB = Convert.ToDouble(Console.ReadLine());
double distance = FindDistance (xA, yA, zA, xB, yB, zB);

Console.WriteLine($"Distance between A and B is {distance}");
*/