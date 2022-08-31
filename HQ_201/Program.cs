int number = new Random().Next(10, 1000);
Console.WriteLine("Введите трехзначное число: ");


int num = 0;

if (1000 > number)
{
    if (number > -1000)
    {
        num = Math.Abs(number % 100 / 10);
        Console.WriteLine(number);
        Console.WriteLine(num);
    }
    else
    {
        Console.WriteLine("Число не трехзначное");
    }
}
else
{
    Console.WriteLine("Число не трехзначное");
}