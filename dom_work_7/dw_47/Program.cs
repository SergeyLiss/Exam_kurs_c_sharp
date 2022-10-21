//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();

double[,] ArrayGeneration(int min = -10, int max = 10)
{
    Console.WriteLine("Будет создан двумерный массив.");
    Console.Write("Введите количество столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество строк: ");
    int m = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[n, m];

    for(int i = 0; i < n; i ++)
        for(int j = 0; j < m; j ++)
        {
            array[i,j] = new Random().NextDouble() * (max-min) + min;
            array[i,j] = Math.Round(array[i,j], 2);
        }

    return array;
}

void PrintTwoArray(double[,] array)
{
    int sizeN = array.GetLength(0);
    int sizeM = array.GetLength(1);

    for(int i = 0; i < sizeN; i ++)
    {
        Console.WriteLine("");
        for(int j = 0; j < sizeM; j ++)
            Console.Write(array[i,j] + "\t");
    }
}

double[,] arrayOne = ArrayGeneration();
PrintTwoArray(arrayOne);
