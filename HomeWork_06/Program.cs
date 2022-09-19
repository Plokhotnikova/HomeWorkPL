//Task 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.WriteLine("Пожалуйста введите M: ");
    int m = int.Parse(Console.ReadLine()); //Прочитаем количество
    int num;
    int cntZero = 0;
    for (int i = 0; i < m; i++)
     {
        Console.WriteLine("Введите число: ");
        num = int.Parse(Console.ReadLine());
        if(num > 0)
        cntZero++;
    }
Console.WriteLine("Количество введенных чисел больше 0 = ", cntZero);
Console.ReadLine();
*/


//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
 
double x =(b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Точка пересечения двух прямых: ({x} ; {y})");
*/
