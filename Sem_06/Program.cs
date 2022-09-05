//создание двумерного массива
int m, n;
Console.WriteLine($"Введите колличество строк: ");
int.TryParse(Console.ReadLine(), out m);
Console.WriteLine($"Введите колличество столбцов: ");
int.TryParse(Console.ReadLine(), out n);

int[,] array = new int[5, 6];

for (int i = 1; i < m; i++)
{
    for (int j = 1; j < m; j++)
    {
        array[i, j] = (i + 1) * (j + 1);
    }
}

for (int i = 1; i < m; i++)
{
    for (int j = 1; j < m; j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
/*foreach (var el1 in array)
{
    Console.Write($"{el1} ");
}
*/