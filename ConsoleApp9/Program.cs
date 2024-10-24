try
{
    double a1 = -13, b1 = -3.5;
    double a2 = 5.8, b2 = 37;
    double a3 = 8, b3 = -15;


    Console.WriteLine($"Исходные значения: A = {a1}, B = {b1}");
    if ((a1 < 0 && b1 > 0) || (a1 > 0 && b1 < 0))
    {
        a1 = -a1;
        b1 = -b1;
    }
    else
    {
        a1 = 0;
        b1 = 0;
    }
    Console.WriteLine($"Результат: A = {a1}, B = {b1}");


    Console.WriteLine($"Исходные значения: A = {a2}, B = {b2}");
    if ((a2 < 0 && b2 > 0) || (a2 > 0 && b2 < 0))
    {
        a2 = -a2;
        b2 = -b2;
    }
    else
    {
        a2 = 0;
        b2 = 0;
    }
    Console.WriteLine($"Результат: A = {a2}, B = {b2}n");


    Console.WriteLine($"Исходные значения: A = {a3}, B = {b3}");
    if ((a3 < 0 && b3 > 0) || (a3 > 0 && b3 < 0))
    {
        a3 = -a3;
        b3 = -b3;
    }
    else
    {
        a3 = 0;
        b3 = 0;
    }
    Console.WriteLine($"Результат: A = {a3}, B = {b3}n");
}
catch
{
    Console.WriteLine("ошибка где то");
}