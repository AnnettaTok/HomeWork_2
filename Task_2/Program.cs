/*  Напишите программу, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */


Console.WriteLine("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 100)
    Console.WriteLine($"{n} третьей цифры нет ");
else
{
    while (n > 999)
    {
        n = n / 10;
    }
    int result = n % 10;
    Console.WriteLine($"{n} -> {result} ");
}