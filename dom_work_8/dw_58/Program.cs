//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] ArrayGeneration(int columnToRow = 0, int min = -10, int max = 10)
{
    int m = new Random().Next(2, 8);
    int n = 0;
    if(columnToRow != 0) {n = columnToRow;}
    else {n = new Random().Next(2, 8);}

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

int[,] MatrixMultiplication(int[,] a, int[,] b)
{
    int column = a.GetLength(0);
    int row = b.GetLength(1);
    int index = a.GetLength(1);
    if(index != b.GetLength(0))
    {
        Console.WriteLine("Матрицы не совместимы. Количество строк матрицы А не равно количеству столбцов матрицы В.");
        return (new int[0,0]);
    }

    int[,] c = new int[column, row];

    for(int i = 0; i < column; i ++)
        for(int j = 0; j < row; j ++)
            for(int k = 0; k < index; k ++)
                c[i,j] += a[i,k] * b[k,j];
    
    return c;
}


Console.WriteLine("\nМатрица A:");
int[,] matrix1 = ArrayGeneration();
PrintTwoArray(matrix1);
Console.WriteLine("\nМатрица B:");
int[,] matrix2 = ArrayGeneration(matrix1.GetLength(1));
PrintTwoArray(matrix2);
Console.WriteLine("\nМатрица C, произведение матриц AxB:");
int[,] matrix3 = MatrixMultiplication(matrix1, matrix2);
PrintTwoArray(matrix3);
