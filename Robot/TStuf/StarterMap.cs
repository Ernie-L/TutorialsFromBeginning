
namespace Robot
{
    public class StarterMap : Map
    {
        public StarterMap() : base()
        {
            Squares = new Square[Width, Height];

            // cover all land
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Squares[x, y] = new WoodFloorSquare(x, y);
                }
            }
            for (int x = 11; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Squares[x, y] = new GrassSquare(x, y);
                }
            }
            for (int x = 0; x < Width; x++)
            {
                for (int y = 6; y < Height; y++)
                {
                    Squares[x, y] = new GrassSquare(x, y);
                }
            }
            //// add some sea
            for (int x = 0; x < Width - 5; x++)
            {
                for (int y = 2; y < Height - 3; y++)
                {
                    Squares[x, y] = new WaterSquare(x, y);
                }
            }
            Squares[0, 4] = new DoorSquare(0, 4, "LEAVE_STARTER_MAP");

            LinkSquares();
        }
    }
}
