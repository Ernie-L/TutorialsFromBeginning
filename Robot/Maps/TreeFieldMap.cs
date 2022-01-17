using Squares;

namespace Maps
{
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