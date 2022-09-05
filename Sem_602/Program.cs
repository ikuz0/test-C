/*int m, n;
Console.WriteLine($"Введите колличество строк: ");
int.TryParse(Console.ReadLine(), out m);
Console.WriteLine($"Введите колличество столбцов: ");
int.TryParse(Console.ReadLine(), out n);

int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = (i + j);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
*/
/*
**Задача 49:** Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные,
 и замените эти элементы на их квадраты.
Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/
/*int m, n;
Console.WriteLine($"Введите колличество строк: ");
int.TryParse(Console.ReadLine(), out m);
Console.WriteLine($"Введите колличество столбцов: ");
int.TryParse(Console.ReadLine(), out n);

int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(-10, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if ((i % 2 == 0) && (j % 2 == 0))
        {
            array[i, j] = array[i, j] * array[i, j];
        }
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        //array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
*/
/***Задача 51:** Задайте двумерный массив. 
Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Сумма элементов главной диагонали: 1+9+2 = 12
*/
int m, n;
Console.WriteLine($"Введите колличество строк: ");
int.TryParse(Console.ReadLine(), out m);
Console.WriteLine($"Введите колличество столбцов: ");
int.TryParse(Console.ReadLine(), out n);

int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(-10, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if ((i % 2 == 0) && (j % 2 == 0))
        {
            array[i, j] = (int)Math.Pow(array[i, j], 2);
        }
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        //array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}