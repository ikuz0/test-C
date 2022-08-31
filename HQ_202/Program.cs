int number = new Random().Next(1, 100000);
Console.WriteLine("Введите число: ");

//определение колличества цифр в числе
int len = number.ToString().Length;

int DigNum(int num, int n)
{
    return num / (int)Math.Pow(10, len - n) % 10;
}
if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine($"{number} -> {DigNum(number, 3)}");
}