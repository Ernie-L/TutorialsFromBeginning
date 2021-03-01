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
                    Squares[x, y] = new Square();
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

    public class Square
    {
        public char Display { get; } = '.';
    }
}
