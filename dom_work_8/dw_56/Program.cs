//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] ArrayGeneration(int min = -10, int max = 50)
{
    Console.WriteLine("Будет создан двумерный массив.");
    int n = new Random().Next(4, 8);
    int m = new Random().Next(4, 8);

    int[,] array = new int[n, m];

    for(int i = 0; i < n; i ++)
        for(int j = 0; j < m; j ++)
            array[i,j] = new Random().Next(min, max);

    return array;
}

void MinimalSumRow(int[,] array)
{
    int sizeN = array.GetLength(0);
    int sizeM = array.GetLength(1);
    int sum = 0;
    int index = 0;

    for(int i = 0; i < sizeN; i ++)
    {
        int temp = 0;

        for(int j = 0; j < sizeM; j ++)
            temp += array[i,j];
        
        if(i==0)
            sum = temp;
        
        if(sum > temp)
        {
            sum = temp;
            index = i;
        }
    }

    Console.WriteLine("Строка {0} содержит минимальную сумму элементов: {1}", index, sum);
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

int[,] array1 = ArrayGeneration();
PrintTwoArray(array1);
MinimalSumRow(array1);
