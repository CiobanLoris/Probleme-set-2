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

        int numarNegative, numarZero, numarPozitive;
        NumaraElemente(secventa, out numarNegative, out numarZero, out numarPozitive);

        Console.WriteLine($"Dintre cele {n} numere, {numarNegative} sunt negative, {numarZero} sunt zero, iar {numarPozitive} sunt pozitive.");

        
        Console.ReadKey();
    }

    static void NumaraElemente(int[] secventa, out int numarNegative, out int numarZero, out int numarPozitive)
    {
        numarNegative = 0;
        numarZero = 0;
        numarPozitive = 0;

        foreach (int numar in secventa)
        {
            if (numar < 0)
            {
                numarNegative++;
            }
            else if (numar == 0)
            {
                numarZero++;
            }
            else
            {
                numarPozitive++;
            }
        }
    }
}
