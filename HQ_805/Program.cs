/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = 0;
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}
void SpinArray(int[,] arr)
{
    int k = 0;
    int i = 0;
    int j = 0;
    int m = arr.GetLength(0);

    while (k < Math.Pow(m, 2))
    {
        if (k < 4)
        {
            while (k != 4)
            {
                arr[i, j] = k;
                j++;
                k++;
            }
        }
        else
        {
            if (k < 7)
            {
                j = j - 1;
                while (k != 7)
                {
                    i++;
                    arr[i, j] = k;
                    k++;
                }
            }
            else
            {
                if (k < 10)
                {
                    while (k != 10)
                    {
                        j--;
                        arr[i, j] = k;
                        k++;
                    }
                }
                else
                {
                    if (k < 12)
                    {
                        while (k != 12)
                        {
                            i--;
                            arr[i, j] = k;
                            k++;
                        }
                    }
                    else
                    {
                        if (k < 14)
                        {
                            while (k != 14)
                            {
                                j++;
                                arr[i, j] = k;
                                k++;
                            }

                        }
                        else
                        {
                            if (k < 15)
                            {
                                while (k != 15)
                                {
                                    i++;
                                    arr[i, j] = k;
                                    k++;
                                }

                            }
                            else
                            {
                                if (k < Math.Pow(m, 2))
                                {
                                    while (k != Math.Pow(m, 2))
                                    {
                                        j--;
                                        arr[i, j] = k;
                                        k++;
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }

    }

}
void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] array = new int[4, 4];
FillArray(array);
SpinArray(array);
PrintArr(array);
