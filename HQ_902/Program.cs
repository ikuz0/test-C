/*
Задача 66: Задайте значения M и N. 
Напишите программу, 
которая найдёт сумму натуральных элементов 
в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


int N, M;
Console.Write($" Введите M:  ");
int.TryParse(Console.ReadLine(), out M);
Console.Write($" Введите N:  ");
int.TryParse(Console.ReadLine(), out N);




int PrintNUmbers(int start, int end)
{
    int summa = 0;
    if (start >= end)
    {
        return start;
    }

    if (start > 0)
    {
        summa = summa + start;
        return summa + PrintNUmbers(start + 1, end);

    }
    else
    {
        start = 0;
        return PrintNUmbers(start + 1, end);
    }

}

Console.WriteLine(PrintNUmbers(M, N));



