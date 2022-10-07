//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int a = new Random().Next(-5,20);

void KubFInterval(int k)
{
    if(k > 0)
    {
        Console.Write("Кубы чисел в интервале от 1 до " + a + " : 1");

        for(int i = 2; i <= k; i ++)
        {
            Console.Write(", " + Math.Pow(i, 3));
        }
        Console.WriteLine(".");
    }
    else Console.WriteLine("Ваше число: " + k + ". Число должно быть натуральным.");
}

KubFInterval(a);