using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea secventei: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] secventa = new int[n];

        
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            secventa[i] = Convert.ToInt32(Console.ReadLine());
        }

        bool suntInOrdineCrescatoare = VerificaOrdineCrescatoare(secventa);

        if (suntInOrdineCrescatoare)
        {
            Console.WriteLine("Numerele din secventa sunt in ordine crescatoare.");
        }
        else
        {
            Console.WriteLine("Numerele din secventa nu sunt in ordine crescatoare.");
        }

        
        Console.ReadKey();
    }

    static bool VerificaOrdineCrescatoare(int[] secventa)
    {
        for (int i = 0; i < secventa.Length - 1; i++)
        {
            if (secventa[i] > secventa[i + 1])
            {
                return false; 
            }
        }

        return true;
    }
}
