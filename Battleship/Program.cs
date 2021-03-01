using System;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Screen.Clear();

            Board board = new Board();
            board.Draw(0,0);


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

        public void Draw(int xTop, int yTop)
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Screen.WriteAt(x.ToString(), xTop, yTop);
                }
            }
        }

        protected void DrawSquares(int xTop, int yTop)
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Screen.WriteAt(Squares[x, y], xTop + x, yTop + y);
                }
            }

        }

        public void Set(int x, int y, char value)
        {

        }
    }
}
