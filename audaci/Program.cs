using System;
using System.Collections.Generic;
using System.Linq;

namespace audaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Modello Dati
            float result = 0;
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
                Console.Write(item);            Debug Line
            }
            */

            // Output
            for(i=0; i < mem.Count(); i++)
            {
                result += 1f/6f;
            }
            result /= 6f;
            Console.WriteLine($"La probabilità che da {n} tiri escano tutte le facce di un dado sono: {(result * 100f).ToString("N2")}%");

        }// Fine Programma
    }
}
