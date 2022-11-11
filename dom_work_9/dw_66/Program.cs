// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

void InConsole()
{
    int result = 0;
    Console.Clear();
    Console.WriteLine("Будут выведена сумма натуральных чисел в диапозоне от N до M.");
    Console.Write("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    
    if((n > 1) & (m > 1))
    {
        result = SumNaturalNumber(m, n);
        Console.WriteLine("Сумма натуральных чисел от {0} до {1}: {2}", n, m, result);
    }
    else {Console.WriteLine("N и M должны быть натуральными.");}
}

int SumNaturalNumber(int finish, int start)
{
    if(finish != start) {return (finish + SumNaturalNumber((finish-1), start));}
    else {return start;}
}

InConsole();
