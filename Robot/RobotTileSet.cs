using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
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

    public static class RobotTileSet
    {
        public static class config
        {
            public const int Width = 8;
            public const int Height = 5;
        };

        public static class Robot
        {
            public static Tile Up { get; } = 
                new Tile(
                    new string[config.Height] { @" ______ ",
                                                @"/ v  v \",
                                                @"|------|",
                                                @"|      |",
                                                @"\______/" });

            public static Tile Right { get; } = 
                new Tile(
                    new string[config.Height] { @" ______ ",
                                                @"/  |   \",
                                                @"|  |  <|",
                                                @"|  |  <|",
                                                @"\__|___/" });

            public static Tile Left { get; } = 
                new Tile(
                    new string[config.Height] { @" ______ ",
                                                @"/   |  \",
                                                @"|>  |  |",
                                                @"|>  |  |",
                                                @"\___|__/" });

            public static Tile Down { get; } = 
                new Tile(
                    new string[config.Height] { @" ______ ",
                                                @"/      \",
                                                @"|      |",
                                                @"|------|",
                                                @"\_^__^_/" });
        }

        public static Tile Grass { get; } = 
            new Tile(
                new string[config.Height] { @"/\|\/|/|",
                                            @"\|/\/|/\",
                                            @"|/\|/|\/",
                                            @"\/|//\|\",
                                            @"\\/|\//\" },
                ConsoleColor.DarkGreen,
                ConsoleColor.DarkYellow);

        public static Tile Water { get; } =
            new Tile(
                new string[config.Height] { @"~/~~/~~~",
                                            @"~~/~~~~~",
                                            @"~/~~~~~/",
                                            @"/~~/~~/~",
                                            @"~/~~/~~~" },
                ConsoleColor.DarkCyan,
                ConsoleColor.White);



        public static class Door
        {
            public static Tile Closed { get; } =
                new Tile(
                    new string[config.Height] { @"        ",
                                                @"  ____  ",
                                                @" / || \ ",
                                                @"| O||O |",
                                                @" \_||_/ " });

            public static Tile Partial { get; } =
                new Tile(
                    new string[config.Height] { @"        ",
                                                @"  ____  ",
                                                @" /|  |\ ",
                                                @"|O|  |O|",
                                                @" \|__|/ " });

            public static Tile Open { get; } =
                new Tile(
                    new string[config.Height] { @"        ",
                                                @"  ____  ",
                                                @" /    \ ",
                                                @"||    ||",
                                                @" \____/ " });

        }
    }
}
