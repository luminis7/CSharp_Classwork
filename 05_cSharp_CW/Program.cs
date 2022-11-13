// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.


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

    Console.WriteLine(" ");
}
/*
int GetNegativeSum(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0)
            sum += array[i];
    return sum;
}
*/
Console.WriteLine("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
/*
int negativeSum = GetNegativeSum(myArray);
Console.WriteLine("Сумма негативных элементов равна "  + negativeSum);
*/
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
bool FindNumber(int[] array, int number)
{
    for(int i = 0; i < array.Length; i++)
        if(number == array[i])
            return true;
    return false;
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool result = FindNumber(myArray, num);

if(result == true)
    Console.WriteLine($"Число {num} присутствует в массиве");
else
    Console.WriteLine($"Число {num} не присутствует в массиве");
*/

// Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
/*
int Sum(int[] array, int num1, int num2)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] >= num1 && array[i] <= num2)
            count++;
    return count;
}

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Sum(myArray, num1, num2));
*/

// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
void Negative(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= (-1);
    }
}
Negative(myArray);
ShowArray(myArray);