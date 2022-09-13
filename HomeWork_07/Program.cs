// Task 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными 
// числами.
/*
double[,] GreateRandon2dArray(int rows, int columns, int minValue, int maxValue) 
{
    double[,] newArray = new double[rows,columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1) + 
            Math.Round(new Random().NextDouble(),1);
        }
    }
    return newArray;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] array = GreateRandon2dArray(m, n, min, max);
Show2dArray(array);
*/



// Task 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет 
/*
int[,] GreateRandon2dArray(int rows, int columns)
{
    int[,] newArray = new int[rows,columns];
    
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(0, 100);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: "); 
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input search number: ");
int num = Convert.ToInt32(Console.ReadLine());

int[,] array = GreateRandon2dArray(m, n);
Show2dArray(array);

// Находим число:

bool IsFinde = false; // Если найдём число, то будет истина
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if(array[i, j] == num)
        {
            IsFinde = true;
        }
    }
}
if (IsFinde)
{
    Console.WriteLine(num + " - число найдено в массиве.");
}
else
{
    Console.WriteLine(num + " - число не найдено.");
}
Console.WriteLine();
*/




// Task 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. 
/*
double[,] GreateRandon2dArray(int rows, int columns, int minValue, int maxValue) 
{
    double[,] newArray = new double[rows,columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1) + 
            Math.Round(new Random().NextDouble(),1);
        }
    }
    return newArray;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] SumOfColumns(double[,] array)
{
    double[] sums = new double[array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        sums[i] = 0.0;
        for(int j = 0; j < array.GetLength(0); j++)
        {
            sums[i] += array[i,j];
        }
    }
    return sums;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] array = GreateRandon2dArray(m, n, min, max);
Show2dArray(array);
Console.WriteLine("The average each of columns: ");
double []sums = SumOfColumns(array);
for (int i = 0; i < sums.GetLength(0); i++);
{
    Console.Write(sums[i] + " ; ");
}
Console.ReadLine();
*/