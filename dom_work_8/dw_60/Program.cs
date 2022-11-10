//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] ArrayGeneration(int min = 10, int max = 100)
{
    Console.WriteLine("Будет создан трехмерный массив.");
    int x = new Random().Next(2, 4);
    int y = new Random().Next(2, 4);
    int z = new Random().Next(2, 4);

    Console.WriteLine("({0},{1},{2})", x, y, z);

    int[,,] array = new int[x, y, z];

    for(int i = 0; i < x; i ++)
        for(int j = 0; j < y; j ++)
            for(int k = 0; k < z; k ++)
            {
                int temp = (i*x) + (j*y) + k;
                array[i,j,k] = temp + 10;
            }

    return array;
}

void PrintThreeArrayElement(int[,,] array)
{
    int sizeX = array.GetLength(0);
    int sizeY = array.GetLength(1);
    int sizeZ = array.GetLength(2);

    for(int i = 0; i < sizeX; i ++)
        for(int j = 0; j < sizeY; j ++)
            for(int k = 0; k < sizeZ; k ++)
                Console.WriteLine("{0} ({1},{2},{3})", array[i,j,k], i, j, k);
}

PrintThreeArrayElement(ArrayGeneration());