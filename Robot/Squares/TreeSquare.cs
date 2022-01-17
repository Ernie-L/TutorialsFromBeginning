using Tiles;

namespace Squares
{
    public class TreeSquare : Square
    {
        public override Tile Tile { get { return FieldTileSet.Tree; } }
        public override string Name { get { return "Tree"; } }
        public override bool Passable { get { return false; } }

        public TreeSquare(int x, int y) : base(x, y) { }
    }

}