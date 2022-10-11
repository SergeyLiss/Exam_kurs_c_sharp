//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int a = new Random().Next(1,10000);

int SumNumberA(int a)
{
    int b = 0;

    while (a > 0)
    {
        b += (a % 10);
        a /= 10;
    }

    return b;
}

Console.WriteLine("Сумма цифр числа " + a + " равна " + SumNumberA(a));
