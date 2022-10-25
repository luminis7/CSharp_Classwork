// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void ShowQuart(int quartNum)
{
    if(quartNum >= 1 && quartNum <= 4)
    {
        if(quartNum ==1) Console.WriteLine("x > 0 and y > 0");
        else if(quartNum == 2) Console.WriteLine("x < 0 and y > 0");
        else if(quartNum == 3) Console.WriteLine("x < 0 and y < 0");
        else Console.WriteLine("x > 0 and y < 0");
    }
    else
    Console.WriteLine("Wrong");
   
}

Console.Write("Input a nimber of quart: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowQuart(num);
*/
// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int Square(double x, double y)
{
   if(x > 0 && y > 0) return 1;
   if(x < 0 && y > 0) return 2;
   if(x < 0 && y < 0) return 3;
   if(x >0 && y > 0) return 4;
    return 0;

}
Console.WriteLine("Введите точку х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Square(x, y));
*/
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
/*
double Distance(double x1, double x2, double y1, double y2)
{
    double catetx = x1 - x2;
    double catety = y1 -y2;
    double gipotenusa = Math.Sqrt(Math.Pow(catetx, 2) + Math.Pow(catety, 2));
    return gipotenusa;
}
Console.WriteLine("Введите точку х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Расстояние между точками равно {Distance(x1, x2, y1, y2)}");
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

void Square(int n)
{
    int index = 1;
    while (index <= n)
    {
        double result = Math.Pow(index, 2);
        Console.Write(result + " ");
        index++;
    }
}

Console.WriteLine("Введите число: ");
int res = Convert.ToInt32(Console.ReadLine());
Square(res);