using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti un numar n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int suma = CalculSuma(n);
        long produs = CalculProdus(n);

        Console.WriteLine($"Suma numerelor de la 1 la {n} este: {suma}");
        Console.WriteLine($"Produsul numerelor de la 1 la {n} este: {produs}");

        
        Console.ReadKey();
    }

    static int CalculSuma(int n)
    {
        int suma = 0;

        for (int i = 1; i <= n; i++)
        {
            suma += i;
        }

        return suma;
    }

    static long CalculProdus(int n)
    {
        long produs = 1;

        for (int i = 1; i <= n; i++)
        {
            produs *= i;
        }

        return produs;
    }
}
