using System;
using System.Collections.Generic;
using System.Text;

namespace Robot
{
    public class Map
    {
        public Square[,] Squares { get; }
        public const int Width = 20;
        public const int Height = 20;

        public Map()
        {
            Squares = new Square[Width, Height];

            // cover all land
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Squares[x, y] = new LandSquare(x, y);
                }
            }

            // add some sea
            for (int x = 0; x < Width; x++)
            {
                for (int y = 10; y < Height; y++)
                {
                    Squares[x, y] = new WaterSquare(x, y);
                }
            }
            for (int x = 5; x < Width; x++)
            {
                for (int y = 2; y < Height; y++)
                {
                    Squares[x, y] = new WaterSquare(x, y);
                }
            }

            LinkSquares();
        }

        private void LinkSquares()
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    if (x - 1 >= 0)     Squares[x, y].Left  = Squares[x - 1, y];
                    if (x + 1 < Width)  Squares[x, y].Right = Squares[x + 1, y];
                    if (y - 1 >= 0)     Squares[x, y].Up    = Squares[x, y - 1];
                    if (y + 1 < Height) Squares[x, y].Down  = Squares[x, y + 1];
                }
            }
        }

        public void Draw()
        {
            Screen.Clear();

            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    char display;
                    Square square = Squares[x, y];

                    if (square.Player != null)
                        display = square.Player.Display;
                    else
                        display = square.Display;

                    Screen.WriteAt(display, x, y);
                }
            }

            // have the next output print under the map.
            Screen.SetCursorPosition(0, Height + 2);
        }
    }
}