//  Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка)

Console.WriteLine("Введите число №1");
int numberA = int.Parse(Console.ReadLine()!);
int result = numberA % 2;

if (result == 0)
{
    Console.WriteLine("Введенное число четное");
}
else
{
    Console.WriteLine("Введенное число не четное");
}