Console.WriteLine("Введите первое число: ");
string numberA = Console.ReadLine();
int numberAint = Convert.ToInt32(numberA);
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