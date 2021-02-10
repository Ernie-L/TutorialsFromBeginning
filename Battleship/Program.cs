using System;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Create a board

            // pick where ships go

            // Play

            // "AI" shoot back
        }
    }

    public class Board
    {
        public enum Ship
        {
            Battleship,
            Destroyer,
            Carrier,
            Sub
        };

        const int Width = 10;
        const int Height = 10;
        char[,] Squares { get; }

        public Board()
        {
            Squares = new char[Width, Height];
            for (int x = 0; x < Width; x++)
                for (int y = 0; y < Height; y++)
                    Squares[x, y] = ' ';

            //Array.ForEach(Squares, c => c=' ');
        }

        public void Draw()
        {

        }

        public void Set(int x, int y, char value)
        {

        }
    }

    public static class Utility
    {
        public static Char GetKeyPress(String msg, Char[] validChars)
        {
            ConsoleKeyInfo keyPressed;
            bool valid = false;

            Console.WriteLine();
            do
            {
                Console.Write(msg);
                keyPressed = Console.ReadKey();
                Console.WriteLine();
                if (Array.Exists(validChars, ch => ch.Equals(Char.ToUpper(keyPressed.KeyChar))))
                    valid = true;
            } while (!valid);
            return keyPressed.KeyChar;
        }
    }
}
