//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] MassivGeneration(int masMin = 10, int masMax = 1000, int masSize = 0)
{
    if(masSize == 0) masSize = new Random().Next(10, 100);

    int[] massiv = new int[masSize];

    for(int i = 0; i < masSize; i ++) massiv[i] = new Random().Next(masMin, masMax);

    return massiv;
}

void SumNechPosition(int[] masDiv)
{
    int sumNP = 0;

    for(int i = 1; i < masDiv.Length; i += 2) sumNP += masDiv[i];
    
    Console.WriteLine("Сумма элементов массива, находящихся на нечетных позициях: " + sumNP + ".");
}

void PrintMassiv(int[] massiv)
{
    int sizeMassiv = massiv.Length;
    Console.WriteLine("Массив состоит из " + sizeMassiv + " элементов:");

    Console.Write("[");

    foreach(int i in massiv) Console.Write(i + ", ");

    Console.WriteLine("].");
}

int[] masTwo = MassivGeneration(-100, 100);
//PrintMassiv(masTwo);
SumNechPosition(masTwo);