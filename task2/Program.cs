// Задача №2.
// Напишите программу, которая на вход принимает два числа и выдаёт,
//  какое число большее, а какое меньшее

Console.WriteLine("Введите число №1: ");
int numberA = int.Parse(Console.ReadLine ()!);

Console.WriteLine("Введите число №2: ");
int numberB = int.Parse(Console.ReadLine ()!);

if (numberA > numberB)
    {
    Console.Write("Первое число больше второго:" + numberA + " > " + numberB);
    }
else if (numberA == numberB)
    {
    Console.WriteLine("Числа равны:" + numberB + " = " + numberA);
    }
else
    {
    Console.WriteLine("Второе число больше первого:" + numberB + " > " + numberA);
    }