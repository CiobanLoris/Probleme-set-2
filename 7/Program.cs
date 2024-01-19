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

        DeterminaMinMax(secventa, out int min, out int max);

        Console.WriteLine($"Cea mai mica valoare din secventa este: {min}");
        Console.WriteLine($"Cea mai mare valoare din secventa este: {max}");

        
        Console.ReadKey();
    }

    static void DeterminaMinMax(int[] secventa, out int min, out int max)
    {
        if (secventa.Length == 0)
        {
            
            min = max = 0;
            return;
        }

        
        min = max = secventa[0];

        
        for (int i = 1; i < secventa.Length; i++)
        {
            if (secventa[i] < min)
            {
                min = secventa[i];
            }

            if (secventa[i] > max)
            {
                max = secventa[i];
            }
        }
    }
}
