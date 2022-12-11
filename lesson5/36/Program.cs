// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int summ = array [0] + array [2] + array [4];
Console.WriteLine(summ);
