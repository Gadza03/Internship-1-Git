using System;

namespace TicTacToe
{
    class Program
    {
        static char[] board = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

        static void PrintBoard()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[1], board[2], board[3]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[4], board[5], board[6]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[7], board[8], board[9]);
            Console.WriteLine("     |     |     ");
        }

        static bool ProvjeriPobjednika(char igrac)
        {
            return (board[1] == igrac && board[2] == igrac && board[3] == igrac) ||
                   (board[4] == igrac && board[5] == igrac && board[6] == igrac) ||
                   (board[7] == igrac && board[8] == igrac && board[9] == igrac) ||
                   (board[1] == igrac && board[4] == igrac && board[7] == igrac) ||
                   (board[2] == igrac && board[5] == igrac && board[8] == igrac) ||
                   (board[3] == igrac && board[6] == igrac && board[9] == igrac) ||
                   (board[1] == igrac && board[5] == igrac && board[9] == igrac) ||
                   (board[3] == igrac && board[5] == igrac && board[7] == igrac);
        }

        static bool PopunjenBoard()
        {
            for (int i = 1; i <= 9; i++)
            {
                if (board[i] == ' ')
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            char igrac = 'X';
            int izborMjesta;

            do
            {
                Console.Clear();
                PrintBoard();

                Console.Write("Igrac {0}, unesi broj (1-9): ", igrac);
                try
                {
                    izborMjesta = int.Parse(Console.ReadLine());
                    if (board[izborMjesta] == ' ')
                    {
                        board[izborMjesta] = igrac;
                        if (ProvjeriPobjednika(igrac))
                        {

                            Console.WriteLine($"Igrac {igrac} pobjedjuje!");
                            break;
                        }
                        if (igrac == 'X') igrac = 'O';
                        else igrac = 'X';
                    }
                    else
                    {
                        Console.WriteLine("Zauzeta pozicija!");
                    }
                }
                catch (System.Exception)
                {
                    Console.Error.WriteLine("NEISPRAVAN UNOS! --> Unesite broj od 1 do 9");
                }
            } while (!PopunjenBoard());

            PrintBoard();

            if (PopunjenBoard() && !ProvjeriPobjednika(igrac)) Console.WriteLine("Izjednaceno je.");
        }
    }
}
