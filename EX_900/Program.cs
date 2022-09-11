/*
**Задача 63.** Задайте значение N. 
Напишите программу, которая выведет все натуральные числа 
в промежутке от 1 до N

Например:
N = 5 -> "1,2,3,4,5"
N = 6-> "1,2,3,4,5,6"
*/

int N;
Console.Write($" Введите N:  ");
int.TryParse(Console.ReadLine(), out N);

PrintNUmbers(1, N);

void PrintNUmbers(int start, int end)
{
    Console.Write($"{start} ");
    if (start < end)
        PrintNUmbers(start + 1, end);
}
