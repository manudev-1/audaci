using System;
using System.Collections.Generic;

namespace audaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Modello Dati
            float result = 0;
            Random gen = new Random();
            int n, rand,i = 0, cont1, cont2, cont3, cont4, cont5, cont6;

            // Input
            cont1 = cont2 = cont3 = cont4 = cont5 = cont6 = 0;
            Console.WriteLine("Inserisci un numero");
            n = int.Parse(Console.ReadLine());

            while (n < 0)
            {
                Console.WriteLine("Numero non valido, Reinseriscilo");
                n = int.Parse(Console.ReadLine());
            }
            // Elaborazione
            while (i < n)
            {
                rand = gen.Next(1,6+1);
                //Console.WriteLine(rand);      Debug Line
                switch (rand)
                {
                    case 1: cont1++; break;
                    case 2: cont2++; break;
                    case 3: cont3++; break;
                    case 4: cont4++; break;
                    case 5: cont5++; break;
                    case 6: cont6++; break;
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
            Console.WriteLine($"Le probabilità che da {n} tiri escano le facce di un dado sono: \n1: {(float)cont1/n * 100f:N2}\n2: {(float)cont2 / n * 100f:N2}\n3: {(float)cont3 / n * 100f:N2}\n4: {(float)cont4 / n * 100f:N2}\n5: {(float)cont5 / n * 100f:N2}\n6: {(float)cont6 / n * 100f:N2}%");

        }// Fine Programma
    }
}
