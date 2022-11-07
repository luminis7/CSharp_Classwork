
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int FindSum(int number)
{
    int sum = 0;
    for(int current = 1; current <= number; current++)
        sum += current;

    return sum;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел от 1 до {a} это {FindSum(a)}");
*/
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int CountNumbers(int number)
{
    int count = 0;
    while(number != 0)
    {
        number /= 10;
        count++;
    }
    return count;
}

Console.WriteLine("Введите число: ");
int temp = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"В числе {temp} {CountNumbers(temp)} цифр");
*/


// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int FindSum(int number)
{
    int mult = 1;
    for(int current = 1; current <= number; current++)
        mult *= current;

    return mult;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Произведение чисел от 1 до {a} это {FindSum(a)}");
*/

//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine(" \n ");
}

Console.WriteLine("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
