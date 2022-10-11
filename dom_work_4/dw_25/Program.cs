//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int a = new Random().Next(-20,20);
int b = new Random().Next(1, 7);

bool[] IntToBin(int number)
{
    int sizeBin = Log2Primit(number);
    bool[] bin = new bool[sizeBin];

    for(int i = (sizeBin-1); i >= 0; i --)
    {
        if ((number & 1) == 1) bin[i] = true;
        else bin[i] = false;

        number >>= 1;
    }

    return bin;
}

int PowAB(int a, int b)
{
   bool[] binaryB = IntToBin(b);
   int sizeBinaryB = binaryB.Length;
   int aStepB = a;

   for(int i = 0; i < sizeBinaryB; i ++)
   {
      aStepB *= aStepB;

      if (binaryB[i] == true)
      {
        aStepB *= a;
        Console.WriteLine("a");
      }
   }

   return aStepB;
}

int Log2Primit(int numberToLog)
{
    int count = 0;

    while (numberToLog != 1)
    {
        numberToLog >>= 1;
        count ++;
    }

    return count;
}


Console.WriteLine("Число " + a + " в степени " + b + " равно " + PowAB(a, b));