namespace Task4;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Unesite prirodni broj n (neparan broj): ");
        int n;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out n))
            {
                break;
            }
            else
            {
                Console.WriteLine("Neispravan unos.");
            }

        }


        for (int i = 1; i <= n; i += 2)
        {
            Console.Write(new string(' ', (n - i) / 2));
            Console.WriteLine(new string('*', i));
        }

        for (int i = n - 2; i >= 1; i -= 2)
        {
            Console.Write(new string(' ', (n - i) / 2));
            Console.WriteLine(new string('*', i));
        }
    }
}
