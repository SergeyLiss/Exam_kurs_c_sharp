int a = new Random().Next(-9,10);
Console.Write("a = ");
Console.WriteLine(a);

int chetn = a & 1;

Console.Write("Число ");
Console.Write(a);

if (chetn == 0) Console.WriteLine(" четное, делится на 2.");
else Console.WriteLine(" нечетное, не делится на 2.");

