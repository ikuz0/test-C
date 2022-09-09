/*
Задача 58: Задайте две матрицы. 
Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


void FillArray(int[,] arr, int m, int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i, j] = new Random().Next(1, 10);
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void multi(int[,] arrA, int[,] arrB, int n1, int m1, int n2, int m2)
{
    if (n1 != m2)
    {
        Console.Write($"Такие матрицы нельзя перемножить, так как количество столбцов матрицы А не равно количеству строк матрицы В.");
    }
    else
    {
        Console.WriteLine($"РЕЗУЛЬТАТ : ");
        int[,] arrayC = new int[m1, n2];
        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n2; j++)
            {
                for (int k = 0; k < m2; k++)
                {
                    arrayC[i, j] += arrA[i, k] * arrB[k, j];

                }
                Console.Write($"{arrayC[i, j]}  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

    }

}
Console.WriteLine("Введите колличество стольбцов матрицы А :  ");
int numstA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите колличество строк матрицы А :  ");
int numstrA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите колличество стольбцов матрицы B :  ");
int numstB = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите колличество строк матрицы B :  ");
int numstrB = int.Parse(Console.ReadLine()!);

int[,] arrayA = new int[numstrA, numstA];
int[,] arrayB = new int[numstrB, numstB];


Console.WriteLine($"Матрица А = ");
FillArray(arrayA, numstA, numstrA);
Console.WriteLine($"Матрица B = ");
FillArray(arrayB, numstB, numstrB);
multi(arrayA, arrayB, numstA, numstrA, numstB, numstrB);
