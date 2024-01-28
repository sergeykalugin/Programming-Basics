using System;

class Program
{
    static void Main()
    {
        int m = 3;
        int n = 2;

        long result = Ackermann(m, n);

        Console.WriteLine($"Ackermann({m}, {n}) = {result}");
    }

    static long Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, (int)Ackermann(m, n - 1));
        }
    }
}
