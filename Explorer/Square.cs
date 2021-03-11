using System;

namespace Explorer
{
    public abstract class Square
    {
        public virtual char Display { get; }
        public virtual string Name { get; }
        public virtual bool Passable { get; }
        public Player Player { get; set; }

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

        public void Draw()
        {
            char display;

            if (Player != null)
                display = Player.Display;
            else
                display = Display;

            Screen.WriteAt(display, X, Y);
        }

        public virtual Square Check(Direction direction)
        {
            Square destination;

            if (direction == Direction.Up) destination = Up;
            else if (direction == Direction.Down) destination = Down;
            else if (direction == Direction.Left) destination = Left;
            else if (direction == Direction.Right) destination = Right;
            else throw new Exception("Don't know where to move.");

            if (destination != null)        // not off the end of the map
            {
                if (destination.Passable)
                {
                    return destination;     // move to new square.
                }
            }

            return null;    // stay on this square
        }
    }

    public class LandSquare : Square
    {
        public override char Display { get { return '.'; } }
        public override string Name { get { return "Land"; } }
        public override bool Passable { get { return true; } }

        public LandSquare(int x, int y) : base(x, y) { }
    }

    public class WaterSquare : Square
    {
        public override char Display { get { return '~'; } }
        public override string Name { get { return "Water"; } }
        public override bool Passable { get { return false; } }

        public WaterSquare(int x, int y) : base(x, y) { }
    }
}