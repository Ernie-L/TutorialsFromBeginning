using Game;
using Squares;

namespace Maps
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
}