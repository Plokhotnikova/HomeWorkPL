// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
/*
int Degree(int num, int n)
{
    
    
    if (n == 0) Console.WriteLine("1");
    else
    {
        if (n < 0) Console.WriteLine("Вы ввели отрицательное число степени.");
    }
    int num_n = 1;
    for (int i = 0; i < n; i++) 
    {
        num_n *= num;
    }
    return num_n;
}

Console.Write("Введите число для возведения его в степень: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное число степени: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = Degree(num,n);
Console.WriteLine(result);
*/


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumOfNumber(int number)
{
    int num = 0;
    int sum = 0;
    int i = 0; 
    while (num < number)
    {
        num = number % 10;
        sum = sum + num;
        i++;
        
    }
    return num;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumOfNumber(number);
Console.WriteLine(result);
*/



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; 
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] biaryArray = CreateRandomArray(8, -999, 999);
ShowArray(biaryArray);
*/
