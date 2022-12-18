// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// int [,] matrix = new int [3, 4];
// void FillArray (int[,] matr)
// {
//     for (int i=0; i < matr.GetLongLength(0); i++)
//     {
//         for (int j=0; j < matr.GetLongLength(1); j++)
//         {
//             matr [i, j] = new Random().Next(-100, 100);
//         }
//     }
// }

// void PrintArray (int[,] matr)
// {
//     for (int i=0; i < matr.GetLongLength(0); i++)
//     {
//         for (int j=0; j < matr.GetLongLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();

Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] twoDimArray = new double[m, n];
Random rnd = new Random();
void PrintArray(double[,] matr)
{ 
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{ 
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matr[i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);
        }
    }
}

FillArray(twoDimArray);
Console.WriteLine();
PrintArray(twoDimArray);