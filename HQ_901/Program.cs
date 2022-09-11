﻿/*
Задача 64: Задайте значение N. 
Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/

int N;
Console.Write($" Введите N:  ");
int.TryParse(Console.ReadLine(), out N);

PrintNUmbers(N, 1);

void PrintNUmbers(int start, int end)
{
    Console.Write($"{start} ");
    if (start > end)
        PrintNUmbers(start - 1, end);
}
