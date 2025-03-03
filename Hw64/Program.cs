﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// Пример:
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите целое положительное число N: ");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int num)
{
    if (num == 0) return;
    Console.Write($"{num},  ");
    NaturalNumber(num - 1);
}

NaturalNumber(number);
Console.WriteLine();

