//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 1000)
{
    while (num > 1000)
    num = num / 10;
    int result = num % 10;
    Console.Write(result);
}    

else if (num < 100)
{
    Console.Write("Третьей цифры нет");
}

else
{
    int result = num % 10;
    Console.Write(result);
}