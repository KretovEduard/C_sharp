// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] arrayRandom (int len)
{
    int [] a = new int [len];
    for (int i=0; i<a.Length; i++)
    {
        a[i] = new Random().Next(0, 100);
    }
    return a;
}

void arrayPrint(int[] a)
{
    for (int i=0; i<a.Length; i++)
        Console.Write($"{a[i]} ");
    Console.WriteLine();
}

int[] array = arrayRandom(5);
arrayPrint(array);

int min = array [0];
if (min > array [1]) min = array [1];
if (min > array [2]) min = array [2];
if (min > array [3]) min = array [3];
if (min > array [4]) min = array [4];
Console.WriteLine($"Минимальное значение: {min}");

int max = array [0];
if (max < array [1]) max = array [1];
if (max < array [2]) max = array [2];
if (max < array [3]) max = array [3];
if (max < array [4]) max = array [4];
Console.WriteLine($"Максимальное значение: {max}");

int result = max - min;
Console.WriteLine($"Разница между максимальным и минимальным значениями: {result}");