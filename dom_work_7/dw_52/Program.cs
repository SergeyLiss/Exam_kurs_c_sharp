// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();

int[,] ArrayGeneration(int min = -30, int max = 30)
{
    Console.WriteLine("Будет создан двумерный массив.");
    Console.Write("Введите количество столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество строк: ");
    int m = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[n, m];

    for(int i = 0; i < n; i ++)
        for(int j = 0; j < m; j ++)
            array[i,j] = new Random().Next(min, max);

    return array;
}

double[] ArrayColumArifmeticMean(int[,] array)
{
    int n = array.GetLength(0);
    int m = array.GetLength(1);

    double[] arrayColArifMean = new double[m];

    for(int i = 0; i < m; i ++)
    {
        int sum = 0;

        for(int j = 0; j < n; j ++)
            sum += array[j,i];
        
        arrayColArifMean[i] = Math.Round(sum/(n*1.0), 2);
    }

    return arrayColArifMean;
}

void PrintTwoArray(int[,] array)
{
    int sizeN = array.GetLength(0);
    int sizeM = array.GetLength(1);

    for(int i = 0; i < sizeN; i ++)
    {
        Console.WriteLine("");
        for(int j = 0; j < sizeM; j ++)
            Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine("");
}

void PrintMassiv(double[] massiv)
{
    int sizeMassiv = massiv.Length;

    Console.WriteLine("");

    foreach(double i in massiv) Console.Write(i + "\t");

    Console.WriteLine("");
}

int[,] arrayOne = ArrayGeneration();
PrintTwoArray(arrayOne);
PrintMassiv(ArrayColumArifmeticMean(arrayOne));