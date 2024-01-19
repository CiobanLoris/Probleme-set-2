using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea secventei: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] secventa = new int[n];

        // Citim elementele secventei
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            secventa[i] = Convert.ToInt32(Console.ReadLine());
        }

        if (EsteSecventaBitonica(secventa))
        {
            Console.WriteLine("Secventa este bitonica.");
        }
        else
        {
            Console.WriteLine("Secventa nu este bitonica.");
        }

        
        Console.ReadKey();
    }

    static bool EsteSecventaBitonica(int[] secventa)
    {
        int n = secventa.Length;

        
        int punctDeViraj = GasestePunctDeViraj(secventa);

        
        if (punctDeViraj == -1 || punctDeViraj == n - 1)
        {
            return false;
        }

        
        for (int i = 0; i < punctDeViraj; i++)
        {
            if (secventa[i] >= secventa[i + 1])
            {
                return false;
            }
        }

        
        for (int i = punctDeViraj + 1; i < n - 1; i++)
        {
            if (secventa[i] <= secventa[i + 1])
            {
                return false;
            }
        }

        return true;
    }

    static int GasestePunctDeViraj(int[] secventa)
    {
        int n = secventa.Length;
        int stanga = 0;
        int dreapta = n - 1;

        while (stanga <= dreapta)
        {
            int mijloc = stanga + (dreapta - stanga) / 2;

            if (mijloc > 0 && mijloc < n - 1)
            {
                if (secventa[mijloc] > secventa[mijloc - 1] && secventa[mijloc] > secventa[mijloc + 1])
                {
                    return mijloc;
                }
            }

            if (secventa[mijloc] > secventa[mijloc - 1])
            {
                stanga = mijloc + 1;
            }
            else
            {
                dreapta = mijloc - 1;
            }
        }

        return -1; 
    }
}
