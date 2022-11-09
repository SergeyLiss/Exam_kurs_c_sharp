//Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] FillingArray(int line = 4) // Вариант 2. От позиции (0,0)(верхний левый угол). Снаружи во внутрь.
{
    int[,] Array = new int[line, line]; // Массив заполняем спирально
    int[,] IndexMax = new int[2, line]; // Массив с количеством максимального появления индекса (0 - по столбцам; 1 - по строкам)
    
    for(int i = 0; i < line; i ++) //
    {
        IndexMax[0, i] = line;
        IndexMax[1, i] = line;
    }

    int column = 0; // Столбец
    int row = 0; // Строка
    bool flagIndex = false; // Флаг на изменение: false - строки; true - столбца.
    int count = 1; // Шаг. Принимает значения: 1 или -1.
    
    for(int i = 0; i < (line*line); i ++)
    {
        Array[column, row] = i;
        IndexMax[0, column] --;
        IndexMax[1, row] --;

        if(!flagIndex)
        {
            if(IndexMax[0, column] != 0) {row += count;}
            else
            {
                flagIndex = true;
                column += count;
            }
        }
        else
        {
            if(IndexMax[1, row] != 0) {column += count;}
            else
            {
                flagIndex = false;
                if(count == 1) {count = -1;}
                else {count = 1;}
                row += count;
            } 
        }
    }
    return Array;
}

void PrintTwoArray(int[,] array) // Вывод массива на экран
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

PrintTwoArray(FillingArray(6));