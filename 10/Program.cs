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

        int numarMaximConsecutiveEgale = NumarMaximConsecutiveEgale(secventa);

        Console.WriteLine($"Numarul maxim de numere consecutive egale din secventa este: {numarMaximConsecutiveEgale}");

        
        Console.ReadKey();
    }

    static int NumarMaximConsecutiveEgale(int[] secventa)
    {
        if (secventa.Length == 0)
        {
            return 0; 
        }

        int numarMaxim = 1;
        int numarCurent = 1;

        for (int i = 1; i < secventa.Length; i++)
        {
            if (secventa[i] == secventa[i - 1])
            {
                numarCurent++;
            }
            else
            {
                numarCurent = 1;
            }

            if (numarCurent > numarMaxim)
                numarMaxim = numarCurent;
            
        }

        return numarMaxim;
    }
}
