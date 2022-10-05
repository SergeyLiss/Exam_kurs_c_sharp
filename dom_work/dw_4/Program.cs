int a = new Random().Next(-9,10);
Console.Write("a = ");
Console.WriteLine(a);
int b = new Random().Next(-9,10);
Console.Write("b = ");
Console.WriteLine(b);
int c = new Random().Next(-9,10);
Console.Write("c = ");
Console.WriteLine(c);

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);