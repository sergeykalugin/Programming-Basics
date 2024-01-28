using System;

class Program
{
    static void Main()
    {
        int M = 5;
        int N = 10;
        Numbers(M, N);
    }

    static void Numbers(int M, int N)
    {
        if (M <= N)
        {
            Console.WriteLine(M);
            Numbers(M + 1, N);
        }
    }
}
