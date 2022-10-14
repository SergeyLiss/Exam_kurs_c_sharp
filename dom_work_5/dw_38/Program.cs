//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


double[] MassivGeneration(int masMin = 0, int masMax = 10, int masSize = 0)
{
    if(masSize == 0) masSize = new Random().Next(10, 100);

    double[] massiv = new double[masSize];

    for(int i = 0; i < masSize; i ++) massiv[i] = new Random().NextDouble() * (masMax-masMin) + masMin;

    return massiv;
}

void IntervalMinMax(double[] masDiv)
{
    double interMin = 0.0;
    double interMax = 0.0;

    foreach(double i in masDiv)
    {
        if(i > interMax) interMax = i;
        else
            if(i < interMin) interMin = i;
    }

    Console.WriteLine("Минимальное значение массива: " + interMin);
    Console.WriteLine("Максимальное значение массива: " + interMax);
    Console.WriteLine("Разность между максимальным и минимальным значениями равна " + (interMax-interMin));
}

void PrintMassiv(double[] massiv)
{
    int sizeMassiv = massiv.Length;
    Console.WriteLine("Массив состоит из " + sizeMassiv + " элементов:");

    Console.Write("[");

    foreach(double i in massiv) Console.Write(i + ", ");

    Console.WriteLine("].");
}

double[] masThree = MassivGeneration(-100, 100);
//PrintMassiv(masThree);
IntervalMinMax(masThree);