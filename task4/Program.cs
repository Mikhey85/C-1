﻿// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел

Console.WriteLine("Введите число №1:");
int numberA = int.Parse(Console.ReadLine ()!);

Console.WriteLine("Введите число №2:");
int numberB = int.Parse(Console.ReadLine ()!);

Console.WriteLine("Введите число №3:");
int numberC = int.Parse(Console.ReadLine ()!);

int max = numberA;

if (numberB > max)
    {
    max = numberB;
    }
if (numberC > max)
    {
    max = numberC;
    }
Console.WriteLine("Максимальное число из трех: " + max);