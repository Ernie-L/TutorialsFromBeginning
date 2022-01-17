using Squares;
using Tiles;

namespace Game
{
    public class RobotPlayer : Player
    {
        protected override Tile TileUp { get { return RobotTileSet.Up; } }
        protected override Tile TileDown { get { return RobotTileSet.Down; } }
        protected override Tile TileLeft { get { return RobotTileSet.Left; } }
        protected override Tile TileRight { get { return RobotTileSet.Right; } }

        public RobotPlayer(Square startSquare) : base(startSquare, RobotTileSet.Right) 
        {
            Direction = Direction.Right;
        }
    }
}
