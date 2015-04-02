using System;
using System.Diagnostics;

public static class FibTimer
{
    public static void Solve()
    {
        long n = 20;
        Stopwatch timer = new Stopwatch();
        timer.Start();
        Console.WriteLine(Loop(n));
        Console.WriteLine(timer.ElapsedTicks + "t");
        Console.WriteLine();
        timer.Restart();
        Console.WriteLine(Recursive(n));
        Console.WriteLine(timer.ElapsedTicks + "t");

        Console.WriteLine();
        Console.WriteLine("done");
        Console.ReadKey();
    }
    public static long Recursive(long n)
    {
        if (n == 0)
            return 0;
        else if (n == 1)
            return 1;
        else
            return Recursive(n - 2) + Recursive(n - 1);
    }
    public static long Loop(long n)
    {
        long f1, f2;
        f1 = 0;
        f2 = 1;
        for (long i = 1; i < n; i++)
        {
            f2 += f1;
            f1 = f2 - f1;
        }
        return f2;
    }
}