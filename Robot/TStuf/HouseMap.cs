
namespace Robot.TStuf
{
    public class HouseMap : Map
    {
        public HouseMap() : base()
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
            for (int x = 2; x < Width; x++)
            {
                for (int y = 2; y < 4; y++)
                {
                    Squares[x, y] = new WaterSquare(x, y);
                }
            }
            for (int x = 0; x < Width; x++)
            {
                for (int y = 4; y < Height - 1; y++)
                {
                    Squares[x, y] = new BrickFloorSquare(x, y);
                }
            }
            Squares[0, 4] = new DoorSquare(0, 4, "LEAVE_FIELD");

            LinkSquares();
        }
    }
}    




    

