using System;
namespace Task3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Unesite maksimalan broj znakova po liniji (m): ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Unesite dužinu linije (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite tekst (završite unos s praznim redom):");
            List<string> tekst = new List<string>();
            string linija;
            while ((linija = Console.ReadLine()) != "")
            {
                tekst.Add(linija);
            }

            string spojeniTekst = string.Join(" ", tekst);

            string[] rijeci = spojeniTekst.Split(' ');

            List<string> linije = new List<string>();

            string trenutnaLinija = "";
            foreach (string rijec in rijeci)
            {
                int razmakZaDodati = 0;
                if (trenutnaLinija.Length > 0) razmakZaDodati = 1;
                else razmakZaDodati = 0;

                int ukupnaDuzina = trenutnaLinija.Length + rijec.Length + razmakZaDodati;
                if (ukupnaDuzina > m)
                {
                    linije.Add(trenutnaLinija);
                    trenutnaLinija = rijec;
                }
                else
                {
                    if (trenutnaLinija.Length > 0)
                    {
                        trenutnaLinija += " ";
                    }
                    trenutnaLinija += rijec;
                }
            }

            if (trenutnaLinija.Length > 0)
                linije.Add(trenutnaLinija);

            foreach (string linijaTekst in linije)
            {
                int razmaciZaDodati = (n - linijaTekst.Length) / 2;
                string poravnataLinija = new string(' ', razmaciZaDodati) + linijaTekst;
                Console.WriteLine(poravnataLinija);
            }
        }
    }

}
