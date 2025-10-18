try
{
    Console.WriteLine("Введите вещественное число А: ");
    double A = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите целое число N (>0): ");
    long N = long.Parse(Console.ReadLine());
    double X = 1;
    if (N > 0)
    {
        for (long i = 0; i < N; i++)
        {
            X *= A;
        }
        Console.WriteLine("A в степени N равно: "+X);
    }
    else
    {
        Console.WriteLine("N меньше или равно нулю, повторите попытку и введите число больше 0");
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}