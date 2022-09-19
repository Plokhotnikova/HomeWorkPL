// Task 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
/*
int[,] GreateRandon2dArray(int rows, int columns, int minValue, int maxValue) // создаём случайный двумерный массив
{
    int[,] newArray = new int[rows,columns]; //выделяем память под двумерный массив
    
    for(int i = 0; i < rows; i++) // прохождение по строкам
    {
        for(int j = 0; j < columns; j++) // прохождение по столбцам
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array) // показываем двумерный массив
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

int[,] SortedMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i,k] > matrix[i, k + 1])
                {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp; 
                }
            }
        }
    }
        
    return matrix;
}
 
Console.Write("Input number of rows: "); // запросили длину строки
int m = Convert.ToInt32(Console.ReadLine()); // вызвали метод, который создаст строку
Console.Write("Input number of columns: "); // запросили количество столбцов
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: "); // запросили у пользователя минимальное и максимальное число массива
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = GreateRandon2dArray(m, n, min, max);
Show2dArray(array);
int[,] newMatrix = SortedMatrix(array);
Show2dArray(newMatrix);
*/


// Task 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2 
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка
/*
int[,] GreateRandon2dArray(int rows, int columns, int minValue, int maxValue) // создаём случайный двумерный массив
{
    int[,] newArray = new int[rows,columns]; //выделяем память под двумерный массив
    
    for(int i = 0; i < rows; i++) // прохождение по строкам
    {
        for(int j = 0; j < columns; j++) // прохождение по 'столбцам/элементам'
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array) // показываем двумерный массив
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

int[,] array = GreateRandon2dArray(m, n, min, max);
Show2dArray(array);


int rows = 0;
int minSumm = SumOll(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int SummRows = SumOll(array, i);
    if (minSumm > SummRows)
    {
        minSumm = SummRows;
        rows = i;
    }
}
int SumOll(int[,] array, int i)
{
    int minSumm = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        minSumm += array[i, j];
    }
    return minSumm;
}

Console.WriteLine($"The smallest amount: {minSumm}");
Console.WriteLine($"This line number: {rows}");
*/


// Task 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
/*
Random random = new Random();
int[,] GreateRandon2dArray(Random random,int rows, int columns, int minValue, int maxValue) // создаём случайный двумерный массив
{
    int[,] newArray = new int[rows, columns]; //выделяем память под двумерный массив
            
    for (int i = 0; i < rows; i++) // прохождение по строкам
    {
        for (int j = 0; j < columns; j++) // прохождение по столбцам
        {

            newArray[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}
void Show2dArray(int[,] array) // показываем двумерный массив
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
int[,] Multiplication(int[,] array1, int[,] array2, int n)
{
    int[,] array3 = new int[n, n];
    for (int i = 0; i<n; i++)
    {
        for (int j = 0; j<n; j++)
        {
            array3[i, j] = 0;
            for(int k=0; k<n; k++)
            {
                array3[i,j] += array1[i,k] * array2[k,j];
            }
        }
    }
    return array3;
}


Console.Write("Input the size of array: "); // запросили размер массива

int n = Convert.ToInt32(Console.ReadLine());
int[,] array1 = GreateRandon2dArray(random,n,n,-100,100);
Show2dArray(array1);
int[,] array2 = GreateRandon2dArray(random,n,n,-200,200);
Show2dArray(array2);
int[,] result = Multiplication(array1, array2,n);
Show2dArray(result);
Console.ReadLine();
*/

// Task 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы 
// каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)
/*
int [,,] Creat3DArray(int n,int m,int k,Random random)
{
    int [,,] data = new int[n,m,k];
    for(int _i = 0; _i < n; _i++)
    {
        for(int _j=0; _j < m; _j++)
        {
            for(int _k = 0; _k < k; _k++)
            {
                data[_i, _j, _k] = random.Next()%90+10;
            }
        }
    }
    return data;
}
 void Show3DArrayByIndex(int [,,]arr)
{
    for (int _i = 0; _i < arr.GetLongLength(0); _i++)
    {
        for (int _j = 0; _j < arr.GetLength(1); _j++)
        {
            for (int _k = 0; _k < arr.GetLength(2); _k++)
            {
                Console.WriteLine("arr["+_i+","+_j+","+_k+"]="+arr[_i, _j, _k]);
            }
        }
    }
}
Random random = new Random();
// Количество двухзначных чисел от 10...99=90
// Значит общее количество элементов не должно перевосходит 90
Console.WriteLine("Please input count fields: ");
int fields=int.Parse(Console.ReadLine());
Console.WriteLine("Please input count rows: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Please input count columns: ");
int cols = int.Parse(Console.ReadLine());
if (rows * fields * cols > 90)
{
    Console.WriteLine("Excusme doesnot create a 3d array with no repeating number");
}
else
{
    int[,,] arr = Creat3DArray(fields, rows, cols, random);
    Show3DArrayByIndex(arr);
    Console.ReadLine();
}
*/


