using System;

namespace Robot
{
    public abstract class Square
    {
        public virtual Tile Tile { get; }
        public virtual string Name { get; }
        public virtual bool Passable { get; }

        private Player _player;

        public Player Player
        {
            get { return _player; }
            set { _player = value; Draw(); }
        }

        public Square Right { get; set; }
        public Square Left { get; set; }
        public Square Up { get; set; }
        public Square Down { get; set; }

        private int X { get; }
        private int Y { get; }

        public Square(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void EnterSquare(Player player)
        {
            if (!Passable)
                throw new Exception("Can't move there!");
            if (Player != null)
                throw new Exception("Already a player in the square.");

            Player = player;
            Draw();
        }

        public void LeaveSquare(Player player)
        {
            if (Player != player)
                throw new Exception("Player can't leave the square bucause they aren't in the square.");

            Player = null;
            Draw();
        }

        public void Draw()
        {
            Tile tile = null;

            // TODO: Draw the player
            if (Player != null)
                tile = Player.Tile;
            else
                tile = this.Tile;

            Console.BackgroundColor = tile.BackgroundColor;
            Console.ForegroundColor = tile.ForegroundColor;

            int startingX = X * RobotTileSet.config.Width;
            int startingY = Y * RobotTileSet.config.Height;

            if (tile.Display.Length != RobotTileSet.config.Height)
                throw new Exception($"Title must be {RobotTileSet.config.Height} high.");

            for (int y=0; y<RobotTileSet.config.Height; y++)
            {
                if (tile.Display[y].Length < RobotTileSet.config.Width)
                    throw new Exception($"Tile must be at least 5 {RobotTileSet.config.Width} wide.");

                for (int x=0; x<RobotTileSet.config.Width; x++)
                {
                    Screen.WriteAt(tile.Display[y][x], startingX + x , startingY + y);
                }
            }

            //Screen.SetCursorPosition(0, Tile.config.Height + 2);
        }

        public virtual Square Neighbor(Direction direction)
        {
            Square neighbor;

            if (direction == Direction.Up) neighbor = Up;
            else if (direction == Direction.Down) neighbor = Down;
            else if (direction == Direction.Left) neighbor = Left;
            else if (direction == Direction.Right) neighbor = Right;
            else 
                throw new Exception("Don't know where to move.");

            return neighbor;    // can be null if off the map.
        }
    }

    public class LandSquare : Square
    {
        public override Tile Tile { get { return RobotTileSet.Grass; } }
        public override string Name { get { return "Land"; } }
        public override bool Passable { get { return true; } }

        public LandSquare(int x, int y) : base(x, y) { }
    }

    public class WaterSquare : Square
    {
        public override Tile Tile { get { return RobotTileSet.Water; } }
        public override string Name { get { return "Water"; } }
        public override bool Passable { get { return false; } }

        public WaterSquare(int x, int y) : base(x, y) { }
    }

    public class DoorSquare : Square
    {
        public override Tile Tile { get { return RobotTileSet.Door.Closed; } }
        public override string Name { get { return "Door"; } }
        public override bool Passable { get { return false; } }

        public DoorSquare(int x, int y) : base(x, y) { }
    }

}