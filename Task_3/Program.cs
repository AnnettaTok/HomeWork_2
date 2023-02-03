/* Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, 
 является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите номер дня недели");
string number = Console.ReadLine();
if (number == "1")
Console.WriteLine("Рабочий день");
else if (number == "2")
Console.WriteLine("Рабочий день");
else if (number == "3")
Console.WriteLine("Рабочий день");
else if (number == "4")
Console.WriteLine("Рабочий день");
else if (number == "5")
Console.WriteLine("Рабочий день");
else if (number == "6")
Console.WriteLine("Выходной день");
else if (number == "7")
Console.WriteLine("Выходной день");
else Console.WriteLine("Ввели не день недели");