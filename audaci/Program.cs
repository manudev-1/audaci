using System;
using System.Collections.Generic;

namespace audaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Modello Dati
            float result;
            Random gen = new Random();
            int n, rand,i = 0, cont = 0;
            List<int> mem = new List<int>();

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
            while (i < n)
            {
                rand = gen.Next(1,6+1);
                //Console.WriteLine(rand);      Debug Line
                if (!mem.Contains(rand))
                {
                    mem.Add(rand);
                    cont++;
                }
                i++;
            }// Fine while

            /*
            foreach(var item in mem)
            {
                Console.Write(item);            Denug Line
            }
            */

            // Output
            result = (float)cont / n;
            Console.WriteLine($"La probabilità che da {n} tiri escano tutte le facce di un dado sono: {result * 100f}%");

        }// Fine Programma
    }
}
