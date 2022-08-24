/*
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int ShowSecondDigit (int numder)
{
    
    int result = (numder % 100)/10;
    return result;
}

Console.Write ("Input 3-digit integer: ");
int num = Convert.ToInt32(Console.ReadLine());
int secondDigit = ShowSecondDigit(num);
Console.Write ($" Second digit of number {num} is {secondDigit}");
*/

/*
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
// С этой задачей у меня двоякое ощущения. С однйо стороны код работает, а как мы знаем If it's stupid, but works, it isn't stupid (:
// Но решение все равно громоздкое, но более изящного способа найти 3 цифру для чисел рандомной разрядности я не придумал)


int FindIndex (int number)
{
    
int result = number;
int index = 0;
for ( int i =0;  result >= 1; i++)
{
result = result / 10;
index++;
} return index;
}

void thirdDigit (int index, int number)
{
    int result = number;
if (index == 3)
{
    result = number % 10;
    Console.Write ($" Third digit of number {number} is {result}");
} else if (index>3)
{
 result = number  % (int) Math.Pow (10, (index - 2));
  result = result  / (int) Math.Pow (10, (index - 3));
 Console.Write ($" Third digit of number {number} is {result}");
}else Console.Write ("No third digit");
}
   Console.Write ("Input integer: ");
int numIn = Convert.ToInt32(Console.ReadLine());
int index = FindIndex (numIn);
thirdDigit(index, numIn);
*/



/*
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
bool IsWeekend (int number)
{
    bool result = false;
    if ((number == 6 ) | (number ==7)) result = true;
    return result;
}
Console.Write ("Input number of a day of a week: ");
int num = Convert.ToInt32(Console.ReadLine());
bool weekEnd = IsWeekend (num);
if (weekEnd == true) Console.Write ($" {num} -> Yes");
else Console.Write ($" {num} -> No");
*/
