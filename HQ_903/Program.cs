/*
Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


int N, M;
Console.Write($" Введите M:  ");
int.TryParse(Console.ReadLine(), out M);
Console.Write($" Введите N:  ");
int.TryParse(Console.ReadLine(), out N);

int PrintNUmbers(int m, int n)
{
    if (m == 0)
    {
        return (n + 1);
    }
    else
    {
        if ((m != 0) && (n == 0))
        {
            return PrintNUmbers(m - 1, 1);
        }
        else
        {
            return PrintNUmbers(m - 1, PrintNUmbers(m, n - 1));
        }
    }


}

Console.WriteLine(PrintNUmbers(M, N));