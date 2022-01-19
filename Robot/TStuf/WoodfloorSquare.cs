namespace Robot
{
    public class WoodFloorSquare : Square
    {
        public override Tile Tile { get { return StarterTileset.Woodfloor; } }
        public override string Name { get { return "Woodfloor"; } }
        public override bool Passable { get { return true; } }

        public WoodFloorSquare(int x, int y) : base(x, y) { }
    }
}
