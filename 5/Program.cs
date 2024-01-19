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

        int numarElementeEgaleCuPozitia = NumaraElementeEgaleCuPozitia(secventa);

        Console.WriteLine($"In secventa, {numarElementeEgaleCuPozitia} elemente sunt egale cu pozitia la care apar.");

        
        Console.ReadKey();
    }

    static int NumaraElementeEgaleCuPozitia(int[] secventa)
    {
        int numarElementeEgaleCuPozitia = 0;

        for (int i = 0; i < secventa.Length; i++)
        {
            if (secventa[i] == i)
            {
                numarElementeEgaleCuPozitia++;
            }
        }

        return numarElementeEgaleCuPozitia;
    }
}
