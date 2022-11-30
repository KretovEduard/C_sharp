// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 0;
int num3 = num1;

while (num1 > 0)
{
    int element = num1 % 10;
    num1 = num1 / 10;
    num2 = num2 * 10;
    num2 = num2 + element;
}

if (num3 == num2)
{
    Console.Write("да");
}
else
{
    Console.Write("нет");
}