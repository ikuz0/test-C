/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int m, n;
Console.WriteLine($"Введите колличество строк: ");
int.TryParse(Console.ReadLine(), out m);
Console.WriteLine($"Введите колличество столбцов: ");
int.TryParse(Console.ReadLine(), out n);

double[,] array = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(-10, 10);
        Console.Write($"{array[i, j]}   ");
    }
    Console.WriteLine();
}
Console.WriteLine();

void Avg(double[,] array)
{
    double sum = 0;
    double asum = 0;
    Console.WriteLine($"Среднее арифметическое>> ");
    for (int i = 0; i < n; i++)
    {
        sum = 0;
        for (int j = 0; j < m; j++)
        {
            sum += array[j, i];

        }
        asum = sum / m;
        Console.WriteLine($"{i + 1}-й столбец  >> {asum:F2}");
    }


}

Avg(array);