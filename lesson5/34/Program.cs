// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] arrayRandom (int len)
{
    int [] a = new int [len];
    for (int i=0; i<a.Length; i++)
    {
        a[i] = new Random().Next(100, 1000);
    }
    return a;
}

void arrayPrint(int[] a)
{
    for (int i=0; i<a.Length; i++)
        Console.Write($"{a[i]} ");
    Console.WriteLine();
}

int[] array = arrayRandom(7);
arrayPrint(array);
int count = 0;

foreach (var n in array)
{
    if (n % 2 == 0) count++; 
}
Console.WriteLine(count);