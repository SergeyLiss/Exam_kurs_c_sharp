//Поэлементное копирование массива
int[] MassivGeneration(int masMin = 10, int masMax = 1000, int masSize = 0, int masLevel = 1)
{
    if(masSize == 0) masSize = new Random().Next(10, 20);

    if(masLevel > 1)
    {
        int[] massiv = new int[][masSize];
        for(int i = 0; i < masLevel; i ++)
            massiv[i] = MassivGeneration(masMin, masMax, masSize, (masLevel-1));
    }
    else
    {
        int[] massiv = new int[masSize];
        for(int i = 0; i < masSize; i ++)
            massiv[i] = new Random().Next(masMin, masMax);
    }
    return massiv;
}

void PrintMassiv(int[] massiv, int masLevel=1)
{
    int sizeMassiv = massiv.Length;
    Console.WriteLine("Массив состоит из " + sizeMassiv + " элементов:");

    foreach(double i in massiv) Console.Write(i + "\t");

    Console.WriteLine("");
}

PrintMassiv(MassivGeneration(10,1000,10,2));