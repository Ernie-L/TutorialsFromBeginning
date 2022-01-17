using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public abstract class Map
    {
        public Square[,] Squares { get; protected set; }
        public const int Width = 14;
        public const int Height = 7;

        public Map()
        {
            Squares = new Square[Width, Height];
        }

        public void LinkSquares()
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
                    Squares[x, y].Draw();
                }
            }

            // have the next output print under the map.
            Screen.SetCursorPosition(0, (Height * Config.Tile.Height) + 2 );
        }
    }

    public class FieldMap : Map
    {
        public FieldMap() : base()
        {
            // cover all land
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Squares[x, y] = new GrassSquare(x, y);
                }
            }

            //// add some sea
            for (int x = 0; x < Width - 2; x++)
            {
                for (int y = 2; y < 4; y++)
                {
                    Squares[x, y] = new WaterSquare(x, y);
                }
            }

            Squares[0, 4] = new DoorSquare(0, 4, "LEAVE_FIELD");

            LinkSquares();
        }
    }

    public class TreeFieldMap : Map
    {
        public TreeFieldMap() : base()
        {
            // cover all land
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Squares[x, y] = new GrassSquare(x, y);
                }
            }

            //// add some trees
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    if ((x % 3 == 0) && (y %2 == 0))
                        Squares[x, y] = new TreeSquare(x, y);
                }
            }

            Squares[0, 4] = new DoorSquare(0, 4, "LEAVE_TREES");

            LinkSquares();
        }
    }
}