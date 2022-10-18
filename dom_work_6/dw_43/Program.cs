//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[] ReadTwoLines()
{
    Console.Clear();
    double[] lines = new double[4];
    int sdvig = 0;
    string[] print = {"Первая прямая, заданная уравнением y = k1 * x + b1 .", "k1", "b1",
                        "Вторая прямая, заданная уравнением y = k2 * x + b2", "k2", "b2"};

    for(int i = 0; i < print.Length; i ++)
    {
        if((i%3) == 0)
        {
            Console.WriteLine(print[i]);
            sdvig ++;
        }
        else
        {
            Console.Write("Введите значение " + print[i] + ": ");
            lines[i-sdvig] = Convert.ToDouble(Console.ReadLine());
        }
    }

    return lines;
}

void IntersectionLines(double[] lines)
{
    if((lines[0]-lines[2]) == 0)
        Console.WriteLine("Заданный прямые - ПАРАЛЛЕЛЬНЫ.");
    else
    {
        double x = (lines[3]-lines[1]) / (lines[0]-lines[2]);
        double y = x * lines[0] + lines[1];

        Console.WriteLine("Точка пересечения заданных прямых: (" + x + "; " + y + ").");
    }
}

IntersectionLines(ReadTwoLines());


