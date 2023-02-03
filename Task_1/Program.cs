/* Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int Getnumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number = Getnumber("Введите трехзначное число");

int Function(int number)
{
int numberFirst = (number%100) /10 ;
int resaut = numberFirst;
return resaut;
}
Console.WriteLine($"{Function(number)}");