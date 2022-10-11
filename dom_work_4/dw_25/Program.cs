//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int a = new Random().Next(-20,20);
int b = new Random().Next(1, 5);

bool[] IntToBin(int number)
{
    bool[] bin = {};
    bool[] binT = {true};
    bool[] binF = {false};

    while (number != 0)
    {
        if ((number & 1) == 1) bin += binT;
        else bin += binF;

        number >>= 1;
    }

    return bin;
}

int PowAB(int a, int b)
{
   bool[] binaryB = IntToBin(b);
   int sizeBinaryB = binaryB.Length;
   int aStepB = a;

   for(int i = 1; i < sizeBinaryB; i ++)
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


Console.WriteLine("Число " + a + " в степени " + b + " равно " + PowAB(a, b));