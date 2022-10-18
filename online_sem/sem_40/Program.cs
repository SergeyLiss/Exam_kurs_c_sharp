//Существование треугольников
int[] a = new int[3];

for(int i = 0; i < 3; i ++)
{
    a[i] = new Random().Next(1, 10);
}

//Проверка треугольника
void Triangle(int[] t)
{
    bool vers = true;

    for(int i = 0; i < 3; i ++)
    {
        if(t[i] > (t[(i+1)%3] + t[(i+1)%3]))
        {
            vers = false;
            break;
        }
    }

    Console.Write("Треугольник со сторонами: " + t[0] + ", " + t[1] + ", " + t[2]);
    if (vers == true)
    {
        Console.WriteLine(" может существовать.");
    }
    else
    {
        Console.WriteLine(" не может существовать.");
    }
}

Triangle(a);