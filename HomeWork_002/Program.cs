// Task 10:  Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

/*
int TwoNumber(int num)
{
    int num1 = num % 100;
    int num2 = num1 / 10;
    return num2;
}

Console.Write("Введите трёхзначное положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 100 || number > 999)
Console.WriteLine("Неправильный ввод числа, результат недостоверен");

int result = TwoNumber(number);
Console.WriteLine("Вторая цифра - " + result);
*/


// Task 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.


/*
int ThirdNumberMetod(int num)
{
    while(num > 999)
    num = num / 10;
    {
        if(num > 99 && num < 999)
        num = num % 10;

        else num = -1;
        Console.WriteLine("Третьей цифры нет.");
        
    }
    
    return num;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = ThirdNumberMetod(number);
Console.WriteLine("Третья цифра этого числа = " + result);
*/



// Task 15: Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.


/*
bool WeekEnd(int num)
{
    if(num == 6 || num == 7) return true;
    else return false;
}

Console.Write("Введите число, соответвующее дню недели, и мы скажем вам, выходной ли этот день: ");
int number = Convert.ToInt32(Console.ReadLine());
 
if(number < 1 || number > 7)
Console.WriteLine("Нет такого дня недели.");
 
bool result = WeekEnd(number);

Console.Write(result);

if(number >= 1 && number <= 5)
Console.WriteLine(" - это будний день.");
if(number == 6 || number == 7)
Console.WriteLine(" - это выходной! Ура!");

*/