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

        if (EsteMonotona(secventa))
        {
            Console.WriteLine("Secventa este monotona.");
        }
        else
        {
            Console.WriteLine("Secventa nu este monotona.");
        }

        
        Console.ReadKey();
    }

    static bool EsteMonotona(int[] secventa)
    {
        bool crescatoare = true;
        bool descrescatoare = true;

        for (int i = 0; i < secventa.Length - 1; i++)
        {
            if (secventa[i] > secventa[i + 1])
            {
                crescatoare = false;
            }

            if (secventa[i] < secventa[i + 1])
            {
                descrescatoare = false;
            }
        }

        
        return crescatoare || descrescatoare;
    }
}
