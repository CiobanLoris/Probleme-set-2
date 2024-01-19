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

        int numarGrupuriConsecutive = NumarGrupuriConsecutive(secventa);

        Console.WriteLine($"Numarul de grupuri de numere consecutive diferite de zero este: {numarGrupuriConsecutive}");

        
        Console.ReadKey();
    }

    static int NumarGrupuriConsecutive(int[] secventa)
    {
        int numarGrupuri = 0;

        for (int i = 0; i < secventa.Length; i++)
        {
            
            if (secventa[i] != 0)
            {
                numarGrupuri++;

                
                while (i < secventa.Length && secventa[i] != 0)
                {
                    i++;
                }
            }
        }

        return numarGrupuri;
    }
}
