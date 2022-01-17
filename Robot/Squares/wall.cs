namespace Robot.Squares
{
    public class WallSquare : Square
    {

        public override Tile Tile { get { return StarterTileset.Wall; } }
        public override string Name { get { return "Wall"; } }
        public override bool Passable { get { return false; } }

        public WallSquare(int x, int y) : base(x, y) { }





    }
}
