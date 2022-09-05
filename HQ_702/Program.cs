/*
Задача 50. Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет

*/

int ni, nj;
Console.WriteLine($"Введите номер строки : ");
int.TryParse(Console.ReadLine(), out ni);
Console.WriteLine($"Введите номер столбца: ");
int.TryParse(Console.ReadLine(), out nj);

Console.WriteLine();

int m = 5, n = 5;
double[,] array = new double[5, 5];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]}  ");
    }
    Console.WriteLine();
}

Console.WriteLine();
if (ni < m && nj < n)
{
    Console.WriteLine($" значение >> {array[ni, nj]}");
}
else
{
    Console.WriteLine($" Такого элемента нет ");
}
