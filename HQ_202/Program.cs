Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int len = number.ToString().Length;
int DigNum(int num, int n)
{
    return num/(int)Math.Pow(10,len-n)%10;
}

Console.WriteLine($"{number} -> {DigNum(number,3)}");
