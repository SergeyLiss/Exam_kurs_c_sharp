//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] MassivGeneration(int masMin = 10, int masMax = 1000, int masSize = 0)
{
    if(masSize == 0) masSize = new Random().Next(10, 100);

    int[] massiv = new int[masSize];

    for(int i = 0; i < masSize; i ++) massiv[i] = new Random().Next(masMin, masMax);

    return massiv;
}

void DivTo2InMas(int[] masDiv)
{
    int count = 0;

    foreach(int i in masDiv)
        if((i & 1) == 0) count ++;
    
    Console.WriteLine("Количество четных чисел в массиве: " + count + ".");
}

void PrintMassiv(int[] massiv)
{
    int sizeMassiv = massiv.Length;
    Console.WriteLine("Массив состоит из " + sizeMassiv + " элементов:");

    Console.Write("[");

    foreach(int i in massiv) Console.Write(i + ", ");

    Console.WriteLine("].");
}

int[] masOne = MassivGeneration(100);
PrintMassiv(masOne);
DivTo2InMas(masOne);