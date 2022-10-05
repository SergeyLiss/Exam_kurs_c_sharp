int a = new Random().Next(1,10);
Console.Write("a = ");
Console.Write(a);

string DayOfWeek(int peremen)
{
    if(peremen > 7) return "Число выходит за пределы дней недели.";
    else
    {
        if(peremen > 5) return "Выходной.";
        else return "Рабочий день.";
    }
}

Console.Write(" -> ");
Console.WriteLine(DayOfWeek(a));
