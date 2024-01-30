int m = 3, n = 2;
Console.WriteLine($"Значение функции Аккермана для m = {m} и n = {n} : {Ackermann(m, n)}");

static int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;

    if (m > 0 && n == 0)
        return Ackermann(m-1, 1);

    if (m > 0 && n > 0)
        return Ackermann(m-1, Ackermann(m, n-1));

    return -1;
}