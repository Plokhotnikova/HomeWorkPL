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
