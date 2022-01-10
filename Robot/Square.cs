using System;

namespace Robot
{
    public abstract class Square
    {
        public virtual string[] Display { get; }
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
        }

        public void LeaveSquare(Player player)
        {
            if (Player != player)
                throw new Exception("Player can't leave the square bucause they aren't in the square.");

            Player = null;
        }

        public void Draw()
        {
            // TODO: Draw the player

            int startingX = X * Tile.config.Width;
            int startingY = Y * Tile.config.Height;

            if (Display.Length != Tile.config.Height)
                throw new Exception($"Title must be {Tile.config.Height} high.");

            for (int y=0; y<Tile.config.Height; y++)
            {
                if (Display[y].Length < Tile.config.Width)
                    throw new Exception($"Tile must be at least 5 {Tile.config.Width} wide.");

                for (int x=0; x<Tile.config.Width; x++)
                {
                    Screen.WriteAt(Display[y][x], startingX + x , startingY + y);
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
        public override string[] Display { get { return Tile.Grass; } }
        public override string Name { get { return "Land"; } }
        public override bool Passable { get { return true; } }

        public LandSquare(int x, int y) : base(x, y) { }
    }

    public class WaterSquare : Square
    {
        public override string[] Display { get { return Tile.Water; } }
        public override string Name { get { return "Water"; } }
        public override bool Passable { get { return false; } }

        public WaterSquare(int x, int y) : base(x, y) { }
    }
}