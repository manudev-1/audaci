using System;

namespace audaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Modello Dati
            float result = 6f/6f * 5f/6f * 4f/6f * 3f/6f * 2f/6f * 1f/6f;
            int n, c = 0;

            // Input
            Console.WriteLine("Inserisci un numero");
            n = int.Parse(Console.ReadLine());

            // Elaborazione
            while (n < 6)
            {
                Console.WriteLine($"La probabilità che da {n} tiri escano tutte le facce di un dado sono: 0%");
                Console.WriteLine("Reinserisci il numero:");
                n = int.Parse(Console.ReadLine());
            }// Fine while
            while (c < n)
            {
                result *= 6f / 6f;
                c++;
            }// Fine while

            // Output
            Console.WriteLine($"La probabilità che da {n} tiri escano tutte le facce di un dado sono: {(result * 100f).ToString("N2")}");

        }// Fine Programma
    }
}
