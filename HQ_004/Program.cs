Console.WriteLine("Введите число: ");
int numberAint = int.Parse(Console.ReadLine()!);
int i=1;
while(i<(numberAint+1))
{
    if(i%2 < 1)
    {
        Console.WriteLine(" ");
        Console.Write(i);
    }
    i++;
}