
namespace Robot.Squares
{
    public class BrickFloorSquare :Square
    {
        
        
            public override Tile Tile { get { return StarterTileset.BrickFloor; } }
            public override string Name { get { return "BrickFloor"; } }
            public override bool Passable { get { return true; } }

            public BrickFloorSquare(int x, int y) : base(x, y) { }
        








    }
}
