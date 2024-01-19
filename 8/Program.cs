using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti valoarea pentru n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int rezultat = Fibonacci(n);

        Console.WriteLine($"Al {n}-lea numar din sirul lui Fibonacci este: {rezultat}");

        
        Console.ReadKey();
    }

    static int Fibonacci(int n)
    {
        if (n <= 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else
        {
            int a = 0;
            int b = 1;
            int rezultat = 0;

            for (int i = 3; i <= n; i++)
            {
                rezultat = a + b;
                a = b;
                b = rezultat;
            }

            return rezultat;
        }
    }
}
