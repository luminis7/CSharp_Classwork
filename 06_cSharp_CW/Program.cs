// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
// int[] CreateRandomArrayFibonacci(int size, int a, int b)
// {
//     int[] array = new int[size];
//     array[0] = a;
//     array[1] = b;
//     for(int i = 2; i < size; i++)
//         array[i] = array[i-1] + array[i-2];
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine(" ");
// }

//void ReverseArray(int[] array)
// {
//     for(int i = 0, j = array.Length - 1; i < j; i++, j--)
//     {
//         int temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }
// }

//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// int[] CopyArray(int[] array)
// {
//     int[] copyArray = new int[array.Length];
//     for(int i = 0; i < array.Length; i++)
//         copyArray[i] = array[i];
//     return copyArray;
// }


// Console.WriteLine("Введите количество элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(n, min, max);
// ShowArray(myArray);
// int[] newarray = CopyArray(myArray);
// ShowArray(newarray);
//ReverseArray(myArray);
//ShowArray(myArray);



//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

bool Triangle(int a, int b, int c)
{
    return a+b > c && a + c > b && c + b > a;
}
Console.WriteLine("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third number: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Triangle(a, b, c));