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

        Console.Write("Introduceti numarul a pentru a determina pozitia in secventa: ");
        int a = Convert.ToInt32(Console.ReadLine());

        int pozitie = CautaNumar(secventa, a);

        if (pozitie != -1)
        {
            Console.WriteLine($"Numarul {a} se afla pe pozitia {pozitie} in secventa.");
        }
        else
        {
            Console.WriteLine($"Numarul {a} nu se afla in secventa. Raspunsul este -1.");
        }

        
        Console.ReadKey();
    }

    static int CautaNumar(int[] secventa, int a)
    {
        for (int i = 0; i < secventa.Length; i++)
        {
            if (secventa[i] == a)
            {
                return i;
            }
        }

        return -1;
    }
}
