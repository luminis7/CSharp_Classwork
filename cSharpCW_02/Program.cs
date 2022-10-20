// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру
// этого числа.
/*
int CutDigit(int number)
{
    int ed = number % 10;
    int sot = number / 100;

    int result = sot * 10 + ed;
    return result;
}

int randNum = new Random().Next(100, 1000);
int newNum = CutDigit(randNum);

Console.WriteLine($"New version of {randNum} is {newNum}");
*/
// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int MaxNumber(int number)
{
    int ed = number % 10;
    int des = number / 10;

    if (ed < des) 
        return des;
    else
        return ed;
}

int randNum = new Random().Next(10, 100);
int resNum = MaxNumber(randNum);

Console.Write($"Наибольшая цифра чила {randNum} это {resNum}  ");
*/

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*
Console.Write("Введите первое число:  ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int secondNum = Convert.ToInt32(Console.ReadLine());
bool Square(int num1, int num2)
{
    if (num1 * num1 == num2 || num2 * num2 == num1)
        return true;
    else
        return false;
}

bool result = Square(firstNum, secondNum);

Console.WriteLine(result);
*/

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
/*
bool Multiple(int num1, int num2)
{
    if (num2 % num1 == 0)
        return true;
    else
        return false;
}

Console.Write("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

bool result = Multiple(firstNum, secondNum);
Console.WriteLine(result);
*/

// Напишите программу, которая принимает на вход три целых числа(a, m, n) и проверяет, кратно ли число a одновременно m и n.

bool Multiple(int num1, int num2, int num3)
{
    if (num1 % num2 == 0 && num1 % num3 == 0)
        return true;
    else
        return false;
}
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int n = Convert.ToInt32(Console.ReadLine());

bool result = Multiple(a, m, n);
Console.WriteLine(result);