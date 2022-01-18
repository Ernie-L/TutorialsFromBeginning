
namespace Robot
{
    public class Bob : Player
    {
        protected override Tile TileUp { get { return BobTileset.Up; } }
        protected override Tile TileDown { get { return BobTileset.Down; } }
        protected override Tile TileLeft { get { return BobTileset.Left; } }
        protected override Tile TileRight { get { return BobTileset.Right; } }

        public Bob(Square startSquare) : base(startSquare, BobTileset.Right)
        {
            Direction = Direction.Right;
        }
    }
}
