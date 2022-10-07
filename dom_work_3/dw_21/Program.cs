//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int[] a = new int[3];
int[] b = new int[3];

for(int i = 0; i < 3; i ++)
{
    a[i] = new Random().Next(-20,20);
    b[i] = new Random().Next(-20,20);
}

double DistanceAB(int[] x, int[] y)
{
    double z = 0;

    for(int i = 0; i < 3; i ++)
    {
        x[i] -= y[i];
        z += Math.Pow(x[i], 2.0);
    }

    z = Math.Pow(z, 0.5);

    return Math.Round(z, 2);
}

Console.WriteLine("Точка A(" + a[0] + ";" + a[1] + ";" + a[2] + ").");
Console.WriteLine("Точка B(" + b[0] + ";" + b[1] + ";" + b[2] + ").");
Console.WriteLine("Расстояние между точками A и B : " + DistanceAB(a, b) + ".");

