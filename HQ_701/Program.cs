/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5     7    -2  -0,2
  1  -3,3     8  -9,9
  8   7,8  -7,1     9
*/
int m, n;
Console.WriteLine($"Введите колличество строк: ");
int.TryParse(Console.ReadLine()!, out m);
Console.WriteLine($"Введите колличество столбцов: ");
int.TryParse(Console.ReadLine()!, out n);

Random x = new Random();
double[,] array = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = Convert.ToDouble(x.Next(-100, 100) / 10.0);
        Console.Write($"{array[i, j]:F1} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
