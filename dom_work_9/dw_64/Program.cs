// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void InConsole()
{
    Console.Clear();
    Console.WriteLine("Будут выведены натуральные числа в диапозоне от N до 1.");
    Console.Write("Введите число N, больше единицы: ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    if(n > 1){Console.WriteLine(NumberDec(n));}
    else {Console.WriteLine("N должно быть больше единицы.");}

    
}

string NumberDec(int number)
{
    if(number != 1) {return (Convert.ToString(number) + ", " + NumberDec(number-1));}
    else {return "1.";}
}

InConsole();
