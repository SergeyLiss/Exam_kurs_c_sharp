int a = new Random().Next(10,100000);
Console.Write("a = ");
Console.Write(a);

string ThreeChisl(int peremen)
{
    string x = Convert.ToString(peremen);
    int y = x.Length;
    if (y < 3) return "третьей цифры нет.";
    return Convert.ToString(x[2]);
}

Console.Write(" -> ");
Console.WriteLine(ThreeChisl(a));

