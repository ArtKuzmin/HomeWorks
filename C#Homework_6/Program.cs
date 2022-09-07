
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
