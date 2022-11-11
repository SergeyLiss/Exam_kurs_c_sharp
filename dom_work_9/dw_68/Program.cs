// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

void InConsole()
{
    int result = 0;
    Console.Clear();
    Console.Write("Введите число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    if((n >= 0) & (m >= 0))
    {
        result = AkkermanFunc(m, n);
        Console.WriteLine("Функция Аккермана: A({0},{1}) -> {2}", m, n, result);
    }
    else {Console.WriteLine("N и M должны быть положительными.");}
}

int AkkermanFunc(int m, int n)
{
    if(m > 0)
    {
        if(n > 0) {return AkkermanFunc((m-1), AkkermanFunc(m, (n-1)));}
        else {return AkkermanFunc((m-1), 1);}
    }
    else {return (n+1);}
}

InConsole();

