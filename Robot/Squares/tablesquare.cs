
namespace Robot.Squares
{       
        public class TableSquare : Square
        {
            public override Tile Tile { get { return StarterTileset.Table; } }
            public override string Name { get { return "Table"; } }
            public override bool Passable { get { return false; } }

            public TableSquare(int x, int y) : base(x, y) { }
        }
}

