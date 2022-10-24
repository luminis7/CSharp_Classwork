/* 
int a  = 31;
double b = -12,45;
string c = "word";
char d = '@';
bool e = true;
Console.WriteLine("My number is " + a);
Console.WriteLine($"My number is {a}" ); */

/*
Console.Write("Введите первое число: ");
int num1  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if(quad2 == num1)
    Console.WriteLine($"Число {num1} квадрат {num2}");
else
    Console.WriteLine($"Число {num1} не квадрат {num2}");
*/

//Задача 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите положительное целове число ");
int number = Convert.ToInt32(Console.ReadLine());

int current = -number;

while(current <= number)
{
    Console.Write(current + "$");
    current++;
}


// Задача 3 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

/*
Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = n % 10;
Console.WriteLine($"Последнее число {n} is {result}");
*/