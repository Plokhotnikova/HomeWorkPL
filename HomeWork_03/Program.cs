// Task 19:
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом. 

/*
bool Palindrom(int number)
{
    if (number % 10 == number / 10000 || number % 100 == number / 1000) return true;
    else return false;
}

Console.WriteLine("Введите пятизначное число для проверки его на палиндромность");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10000 || num > 99999)
    Console.WriteLine("Это не пятизначное число");

bool result = Palindrom(num);
Console.WriteLine(result);
*/


/*
void Palindrom(int[] array)
{
    int n = array.Length;
    int index = 0;
    while (index < n)
    {
        if (array[index] != array[n - 1])
        Console.WriteLine("Это не палиндром.");
        break;
    }
    index++;
    n--;
}
Console.WriteLine("Введите любое число для проверки его на палиндромность");
int number = Convert.ToInt32(Console.ReadLine());

int[] convertarray = String.Split(',').Select(number => Convert.ToInt32(number)).ToArray();
Palindrom(convertarray);
Console.WriteLine("Это палиндром.");
*/


// Task 21:
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
/*
double Length(double xa, double ya, double xb, double yb, double za, double zb)
{
    double length = Math.Sqrt((xb - xa)*(xb - xa)+(yb - ya)*(yb - ya)+(zb -za)*(zb -za));
    return length;
}

Console.Write("Введите значение х точки А: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение y точки А: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение z точки А: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение х точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение z точки B: ");
int zb = Convert.ToInt32(Console.ReadLine());


double length = Length(xa, ya, xb, yb, za, zb);
Console.Write($"Расстояние между точками А и В равно {length}");
*/


// Task 23:
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube(double number)
{
    int variable = 1;
    while (variable <= number)
    {
        Console.Write(variable*variable*variable + " ");
        variable++;
    }
}

Console.Write("Введите целое положительное число: ");
double number = Convert.ToDouble(Console.ReadLine());
if (number <= 0) Console.Write("Введёное число не соответствует заданным параметрам.");
else Cube(number);
Console.WriteLine();
*/
