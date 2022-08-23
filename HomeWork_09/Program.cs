// Task 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N.
/*
void NaturalsNumber (int m, int n)
{
    if(m > n) 
    {
        int temp = n;
        n = m;
        m = temp;
    }
    if(n != m) NaturalsNumber(m, n - 1);
    Console.Write(n + " ");
}

Console.Write("Введите число m: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n1 = Convert.ToInt32(Console.ReadLine());

NaturalsNumber(n1,m1);
Console.WriteLine();
*/



// Task 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
/*
void Number(int m, int n)
{
    if(m > n) 
    {
        int temp = n;
        n = m;
        m = temp;
    }
    if(n != m) Number(m, n - 1);
}

int SumOfNumber(int m, int n)
{
    // return m == n? n : m + SumOfNumber(m + 1, n);
    if (m == n) return n;
    else n = m + SumOfNumber(m + 1, n); return n;
}

Console.Write("Введите число m: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumOfNumber(num1, num2));
*/



// Task 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
/*
int Ackerman(int m, int n)
{
    if (m < 0 || n < 0) return -1; 
    else if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Ackerman(m - 1, 1);
    else return Ackerman(m - 1, Ackerman(m, n - 1));
}

Console.Write("Введите число m: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Ackerman(m1, n1));
*/
