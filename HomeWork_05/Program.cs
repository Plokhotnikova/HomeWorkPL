// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size]; //создаём объект "новый массив", тип у 
    // него - целочисленный массив, команда new - это выделение памяти под массив
    // и умножаем на размер массива
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(100, 1000);
    }
    return newArray;
}
int SumOfEven(int[] array)

{
    int count = 0; // создали переменную, которая будет собирать количество чётных чисел
    for(int i = 0; i < array.Length; i++) 
    // создали цикл, который проходится по массиву и определяет
    // нужно считать число или нет
       {
        if (array[i] % 2 == 0) count++;
       } 
    return count;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Input size of array: "); // запросили параметры массива
int size = Convert.ToInt32(Console.ReadLine()); // вызвали метод, который его создаст

int[] array = CreateRandomArray(size);
ShowArray(array);

int sum = SumOfEven(array);
Console.WriteLine("Количество чётных чисел: " + sum);
*/



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumOfPosition(int[] array)

{
    int count = 0;
    for(int i = 0; i < array.Length; i++) 
    {
        if (array[i] % 2 == 0) count = array.Length / 2 + 1;
        else count = array.Length / 2;
    }
    return count;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min,max);
ShowArray(array);
int sum = SumOfPosition(array);
Console.WriteLine("Количество чисел на нечётных позициях: " + sum);
*/





// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size]; //создаём объект "новый массив", тип у 
    // него - целочисленный массив, команда new - это выделение памяти под массив
    // и умножаем на размер массива
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int DiffMaxMin(int[] array)

{
    int max = 0;
    for(int i = 0; i < array.Length; i++) 
    {
        if(array[i] > max) max = array[i];
    } 
    return max;

    int min = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
    }
    int diff = max - min;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min,max);
ShowArray(array);

int difference = DiffMaxMin(array);
Console.WriteLine("Количество чисел на нечётных позициях: " + diff);
*/