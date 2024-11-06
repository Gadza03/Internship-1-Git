using System;
using System.Linq;

namespace Permutacije
{
    class Program
    {
        static void Main(string[] args)
        {
            // Unos niza brojeva s razmacima
            Console.Write("Unesite brojeve (odvojene razmacima): ");
            string unos = Console.ReadLine();
            string[] niz = unos.Split(' ').ToArray();
            int[] nizBrojeva = new int[niz.Length];
            for (int i = 0; i < niz.Length; i++)
            {
                nizBrojeva[i] = int.Parse(niz[i]);
            }
            System.Console.WriteLine(nizBrojeva);
            GenerirajPermutacije(nizBrojeva, 0);
        }

        static void GenerirajPermutacije(int[] niz, int pocetak)
        {
            if (pocetak == niz.Length)
            {
                foreach (int broj in niz)
                {
                    Console.Write(broj + " ");
                }
                Console.WriteLine();
                return;
            }

            for (int i = pocetak; i < niz.Length; i++)
            {
                Zamijeni(niz, pocetak, i);

                GenerirajPermutacije(niz, pocetak + 1);

                Zamijeni(niz, pocetak, i);
            }
        }

        static void Zamijeni(int[] niz, int i, int j)
        {
            int temp = niz[i];
            niz[i] = niz[j];
            niz[j] = temp;
        }
    }
}
