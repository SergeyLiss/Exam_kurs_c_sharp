//Число в двоичное исчисление

int a = new Random().Next(1, 1000000);

string AtoBin(int a)
{
    string c = "";
    string b = Convert.ToString((a & 1));

    if (a > 0)
    {
        c = AtoBin((a >> 1)) + b;
        return c;
    } 
    else
    {
        return "0b";
    }
}


Console.WriteLine(a + "\t" + AtoBin(a) + "\n\t0b" + Convert.ToString(a, 2));
