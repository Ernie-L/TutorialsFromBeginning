using System;
using System.Collections.Generic;
using System.Text;

namespace Explorer
{
    //// Goal: 1. Abstract class of Square with different concrete 
    ///           classes like land and water.
    ///        2. Have the map store arrays of squares.
    ///        3. Have the player move around the new map.
    ///        
    //// Quiz: Add a new type of square... without changing code outside the Map.cs file.

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

    public abstract class Square
    {
        public virtual char Display { get; }
        public virtual string Name { get; }
        public virtual bool Passable { get; }
    }

    public class LandSquare : Square
    {
        public override char Display { get { return '.'; } }
        public override string Name { get { return "Land"; } }
        public override bool Passable { get { return true; } }
    }

    public class WaterSquare : Square
    {
        public override char Display { get { return '~'; } }
        public override string Name { get { return "Water"; } }
        public override bool Passable { get { return false; } }
    }
}