int a = new Random().Next(2,20);
Console.Write("a = ");
Console.WriteLine(a);

Console.Write("Все четные числа в интервале от 2 до 'a': 2");

for(int i = 4; i <= a; i += 2)
{
    Console.Write(", ");
    Console.Write(i);
}

Console.WriteLine(".");

