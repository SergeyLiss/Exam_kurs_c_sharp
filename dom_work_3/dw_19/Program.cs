//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int a = new Random().Next(10000, 100000);

string PolindromF(int x)
{
    string z = Convert.ToString(x);

    for(int i = 0; i < 2; i ++)
    {
        if(z[i] != z[4-i])
        {
            return ("Число " + x + " не является полиндромом.");
        }
    }

    return ("Число " + x + " - полиндром.");
}

Console.WriteLine(PolindromF(a));

