int a = new Random().Next(100,1000);
Console.Write("a = ");
Console.Write(a);

int TwoChisl(int peremen)
{
    int x = peremen / 10;
    x %= 10;
    return x;
}

Console.Write(" -> ");
Console.WriteLine(TwoChisl(a));