using Tiles;

namespace Squares
{
    public class WaterSquare : Square
    {
        public override Tile Tile { get { return FieldTileSet.Water; } }
        public override string Name { get { return "Water"; } }
        public override bool Passable { get { return false; } }

        public WaterSquare(int x, int y) : base(x, y) { }
    }

}