using Tiles;

namespace Squares
{
    public class GrassSquare : Square
    {
        public override Tile Tile { get { return FieldTileSet.Grass; } }
        public override string Name { get { return "Land"; } }
        public override bool Passable { get { return true; } }

        public GrassSquare(int x, int y) : base(x, y) { }
    }

}