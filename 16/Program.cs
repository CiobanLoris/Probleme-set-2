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

        if (EsteSecventaBitonicaRotita(secventa))
        {
            Console.WriteLine("Secventa este o secventa bitonica rotita.");
        }
        else
        {
            Console.WriteLine("Secventa nu este o secventa bitonica rotita.");
        }

        // Adăugați această linie pentru a menține fereastra terminalului deschisă până când apăsați o tastă
        Console.ReadKey();
    }

    static bool EsteSecventaBitonicaRotita(int[] secventa)
    {
        int n = secventa.Length;

        // Cautam punctul de viraj, unde secventa devine descrescatoare
        int punctDeViraj = GasestePunctDeViraj(secventa);

        // Daca nu gasim un punct de viraj, secventa nu este bitonica rotita
        if (punctDeViraj == -1 || punctDeViraj == n - 1)
        {
            return false;
        }

        // Verificam daca secventa este monotona crescatoare inainte de punctul de viraj
        for (int i = 0; i < punctDeViraj; i++)
        {
            if (secventa[i] >= secventa[i + 1])
            {
                return false;
            }
        }

        // Verificam daca secventa este monotona descrescatoare dupa punctul de viraj
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

        return -1; // Nu există punct de viraj în secvență
    }
}
