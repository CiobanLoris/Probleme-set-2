using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti secventa de 0 si 1 (separate prin spatiu): ");
        string[] input = Console.ReadLine().Split(' ');

        int[] secventa = new int[input.Length];

        
        for (int i = 0; i < input.Length; i++)
        {
            secventa[i] = Convert.ToInt32(input[i]);
        }

        Tuple<bool, int> rezultat = VerificaSecventaParanteze(secventa);

        if (rezultat.Item1)
        {
            Console.WriteLine("Secventa este corecta.");
            Console.WriteLine($"Nivelul maxim de incuibare: {rezultat.Item2}");
        }
        else
        {
            Console.WriteLine("Secventa nu este corecta.");
        }

        
        Console.ReadKey();
    }

    static Tuple<bool, int> VerificaSecventaParanteze(int[] secventa)
    {
        int nivelMaxim = 0;
        int nivelCurent = 0;

        foreach (int paranteza in secventa)
        {
            if (paranteza == 0)
            {
                nivelCurent++;

                if (nivelCurent > nivelMaxim)
                {
                    nivelMaxim = nivelCurent;
                }
            }
            else if (paranteza == 1)
            {
                if (nivelCurent > 0)
                {
                    nivelCurent--;
                }
                else
                {
                    return Tuple.Create(false, -1); 
                }
            }
            else
            {
                return Tuple.Create(false, -1); 
            }
        }

        
        if (nivelCurent == 0)
        {
            return Tuple.Create(true, nivelMaxim);
        }
        else
        {
            return Tuple.Create(false, -1); 
        }
    }
}
