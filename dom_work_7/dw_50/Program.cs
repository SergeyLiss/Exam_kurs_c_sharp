//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
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

void ArraySearch(int[,] array)
{
    Console.Write("Введите номер столбца: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер строки: ");
    int m = Convert.ToInt32(Console.ReadLine());

    if(0 < n && 0 < m && n <= array.GetLength(0)
                        && m <= array.GetLength(1))
        Console.WriteLine("Число в столбце {0} и строке {1}: {2}",
                                                n, m, array[n-1,m-1]);
    else
        Console.WriteLine("Cтолбец {0} и строка {1} лежат за пределами массива с размерами {2}x{3}.",
                                                             n, m, array.GetLength(0), array.GetLength(1));
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

int[,] arrayOne = ArrayGeneration();
PrintTwoArray(arrayOne);
ArraySearch(arrayOne);