using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea secventei: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[] secventa = new double[n];

        
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            secventa[i] = Convert.ToDouble(Console.ReadLine());
        }

        double sumaInverselor = CalculeazaSumaInverselor(secventa);

        Console.WriteLine($"Suma inverselor este: {sumaInverselor}");

        
        Console.ReadKey();
    }

    static double CalculeazaSumaInverselor(double[] secventa)
    {
        double sumaInverselor = 0;

        for (int i = 0; i < secventa.Length; i++)
        {
            sumaInverselor += 1 / secventa[i];
        }

        return sumaInverselor;
    }
}
