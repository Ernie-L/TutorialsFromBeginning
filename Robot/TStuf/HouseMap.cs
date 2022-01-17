
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
                    Squares[x, y] = new BrickFloorSquare(x, y);
                }
            }

            Squares[5, 6] = new Table(5, 6);

            for (int x = 7; x < Width - 6; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Squares[x, y] = new WallSquare(x, y);
                }
            }
            Squares[7, 3] = new BrickFloorSquare(7, 3);
            Squares[10, 6] = new Table(10, 6);
            Squares[10, 3] = new Table(10, 3);
            Squares[10, 0] = new Table(10, 0);
            Squares[5, 6] = new Table(5, 6);









            Squares[0, 4] = new DoorSquare(0, 4, "LEAVE_HOUSE");

            LinkSquares();
        }
    }
}    




    

