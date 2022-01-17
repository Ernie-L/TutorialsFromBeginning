using Game;
using Squares;

namespace Maps
{
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
}