/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Sum(int[,] arr)
{
    int summa = 0;
    int min = 0;
    int minIndex = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        min += arr[0, j];

    }
    Console.WriteLine($"Sum>>{min} ");
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summa += arr[i, j];
        }
        if (min > summa)
        {
            minIndex = i;
        }
        Console.WriteLine($"Sum>>{summa} ");
    }
    Console.WriteLine($"Sum>>{minIndex + 1} ");
}

int[,] array = new int[5, 6];

FillArray(array);
Sum(array);