//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] ArrayGeneration(int min = 1, int max = 30)
{
    Console.WriteLine("Будет создан двумерный массив.");
    int n = new Random().Next(4, 9);
    int m = new Random().Next(4, 9);

    int[,] array = new int[n, m];

    for(int i = 0; i < n; i ++)
        for(int j = 0; j < m; j ++)
            array[i,j] = new Random().Next(min, max);

    return array;
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

int[,] SortArrayRow(int[,] array) //Сортировка вставками
{
    int column = array.GetLength(0);
    int row = array.GetLength(1);
    int halfRow = row >> 1;

    for(int i = 0; i < column; i ++)
        for(int j = 0; j < (row-1); j ++)
            for(int k = (j+1); k < row; k ++)
                if(array[i,j] < array[i,k])
                    {
                        int temp = array[i,j];
                        array[i,j] = array[i,k];
                        array[i,k] = temp;
                    }
    return array;
}

int[,] array1 = ArrayGeneration();
PrintTwoArray(array1);
int[,] array2 = SortArrayRow(array1);
PrintTwoArray(array2);
