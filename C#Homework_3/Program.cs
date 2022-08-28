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

