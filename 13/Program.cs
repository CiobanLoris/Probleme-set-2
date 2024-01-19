using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea secventei: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] secventa = new int[n];
        int k = 0;
        
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            secventa[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(int i = 0; i < n-1 ;i++)
        {
            if (secventa[i] > secventa[i + 1])
                k++;
        }

        if (k>1)
        {
            Console.WriteLine("Secventa nu o secventa crescatoare rotita.");
        }
        else
        {
            Console.WriteLine("Secventa este este o secventa crescatoare rotita.");
        }

        
        Console.ReadKey();
    }
   
}
