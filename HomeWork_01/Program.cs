// Task 1
// Напишите программу, которая на вход принимает 2 числа и выдаёт, 
// какое число большее, а какое меньшее.

/*
int num1, num2;
string result;

Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2) result = "max = " + num1;
else result = "max = " + num2;

Console.WriteLine(result);
*/


// Task 2: Напишите программу, которая принимает на вход три числа 
//  и выдает максимальное из этих чисел.

/*
int num1, num2, num3;
string result;

Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third integer number: ");
num3 = Convert.ToInt32(Console.ReadLine()); 

if(num1 > num2 && num1 > num3) result = "max = " + num1;
if(num2 > num1 && num2 > num3) result = "max = " + num2;
else result = "max = " + num3;

Console.WriteLine(result);
*/


// Task 3: Напишите программу, которая на вход принимает число и 
// выдает,является ли число чётным (делится ли оно на 2 без остатка)

/*
int num;
string result;

Console.Write("Input integer number: ");
num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0) result = "Yes";
else result = "No";

Console.WriteLine(result);
*/


// Task 4: Напишите программу, которая на входе принимает число N, 
// а на выходе показывает все чётные числа от 1 до N

/*
Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 0;
while(current <= num)
{
    if(current % 2 == 0)
    Console.WriteLine(current + " ");
    current++;
}    
*/