int a = new Random().Next(10,10000);
Console.Write("a = ");
Console.Write(a);

int ThreeChisl(int peremen)
{
    int x = peremen / 100;
    x %= 10;
    return x;
}

Console.Write(" -> ");

if(a < 100) Console.WriteLine("третьей цифры нет.");
else Console.WriteLine(ThreeChisl(a));
