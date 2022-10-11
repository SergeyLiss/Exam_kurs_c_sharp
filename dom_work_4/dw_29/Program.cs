//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (на входе N- длина массива, min и max- ограничения для значений элементов массива, которые лежат в [min, max])
int n = 8;
int min = 1;
int max = 20;

int[] MassivSizeN(int n, int min, int max)
{
    int[] massiv = new int[n];

    for(int i = 0; i < n; i ++)  massiv[i] = new Random().Next(min, max);

    return massiv;
}

void PrintMassiv(int[] massiv)
{
    int sizeMassiv = massiv.Length;
    Console.WriteLine("Массив из " + sizeMassiv + " элементов:");

    Console.Write("[");

    for(int i = 0; i < (sizeMassiv-1); i ++)
    {
        Console.Write(massiv[i] + ", ");
    }

    Console.WriteLine(massiv[sizeMassiv-1] + "].");
}

PrintMassiv(MassivSizeN(n, min, max));