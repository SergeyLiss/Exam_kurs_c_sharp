//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int a = 0;
while (a < 1)
{
    Console.Clear();
    Console.Write("Введите число больше нуля: ");
    a = Convert.ToInt32(Console.ReadLine());
}

int[] MassivGeneration(int masSize = 0, int masMin = -100, int masMax = 100)
{
    if(masSize == 0) masSize = new Random().Next(10, 100);

    int[] massiv = new int[masSize];

    for(int i = 0; i < masSize; i ++) massiv[i] = new Random().Next(masMin, masMax);

    return massiv;
}

void MasElementNull(int[] masN)
{
    int count = 0;

    foreach(int i in masN)
        if(i > 0)
            count  += 1;

    Console.Write("В массиве из " + masN.Length + " элементов содержится " + count + " элемента(ов) больше нуля.");
}

void PrintMassiv(int[] massiv)
{
    int sizeMassiv = massiv.Length;
    Console.WriteLine("Массив состоит из " + sizeMassiv + " элементов:");

    foreach(int i in massiv) Console.Write(i + "\t");

    Console.WriteLine("");
}

int[] b = MassivGeneration(a);
PrintMassiv(b);
MasElementNull(b);