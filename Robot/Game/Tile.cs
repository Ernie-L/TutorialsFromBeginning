namespace Game
{
    public class Tile
    {
        public string[] Display { get; }

        public ConsoleColor BackgroundColor { get;  }

        public ConsoleColor ForegroundColor { get; }

        public Tile(string[] display, ConsoleColor backgroudColor, ConsoleColor foregroundColor)
        {
            Display = display;
            ForegroundColor = foregroundColor;
            BackgroundColor = backgroudColor;
        }
        public Tile(string[] display) : this(display, ConsoleColor.Black, ConsoleColor.White)
        {}
    }
}
