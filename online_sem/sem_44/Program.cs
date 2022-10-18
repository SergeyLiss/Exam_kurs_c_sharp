//Числа Фибоначи
int a = -1;
do
{
    Console.Clear();
    Console.Write("Введите число больше нуля: ");
    a = Convert.ToInt32(Console.ReadLine());
}
while (a < 1);

int[] FibNumber(int size)
{
    int[] fibonachi = new int[size];
    fibonachi[0] = 0;
    fibonachi[1] = 1;

    for(int i = 2; i < size; i ++)
        fibonachi[i] = fibonachi[i-1] + fibonachi[i-2];
    
    return fibonachi;
}

void PrintMassiv(int[] massiv)
{
    int sizeMassiv = massiv.Length;
    Console.WriteLine("Массив состоит из " + sizeMassiv + " элементов:");

    foreach(double i in massiv) Console.Write(i + "\t");

    Console.WriteLine("");
}

PrintMassiv(FibNumber(a));