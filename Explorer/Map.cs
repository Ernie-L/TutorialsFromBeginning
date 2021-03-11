using System;
using System.Collections.Generic;
using System.Text;

namespace Explorer
{
    public class Map
    {
        public Square[,] Squares { get; }
        public const int Width = 20;
        public const int Height = 20;

        public Map()
        {
            Squares = new Square[Width, Height];
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Squares[x, y] = new LandSquare();
                }
            }

            for (int x = 15; x < Width; x++)
            {
                for (int y = 14; y < Height; y++)
                {
                    Squares[x, y] = new WaterSquare();
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
                    char display = Squares[x, y].Display;
                    Screen.WriteAt(display, x, y);
                }
            }

            // have the next output print under the map.
            Screen.SetCursorPosition(0, Height + 2);
        }

        public void Draw(int x, int y)
        {
            char display = Squares[x, y].Display;
            Screen.WriteAt(display, x, y);
        }
    }
}