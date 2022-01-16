using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public static class RobotTileSet 
    {
        public static Tile Up { get; } =
            new Tile(
                new string[Config.Tile.Height] {@" ______ ",
                                                @"/ v  v \",
                                                @"|------|",
                                                @"|      |",
                                                @"\______/" });

        public static Tile Right { get; } =
            new Tile(
                new string[Config.Tile.Height] {@" ______ ",
                                                @"/  |   \",
                                                @"|  |  <|",
                                                @"|  |  <|",
                                                @"\__|___/" });

        public static Tile Left { get; } =
            new Tile(
                new string[Config.Tile.Height] {@" ______ ",
                                                @"/   |  \",
                                                @"|>  |  |",
                                                @"|>  |  |",
                                                @"\___|__/" });

        public static Tile Down { get; } =
            new Tile(
                new string[Config.Tile.Height] {@" ______ ",
                                                @"/      \",
                                                @"|      |",
                                                @"|------|",
                                                @"\_^__^_/" });
    }

    public class DoorTileSet
    {       
        public static Tile Closed { get; } =
            new Tile(
                new string[Config.Tile.Height] {@"        ",
                                                @"  ____  ",
                                                @" / || \ ",
                                                @"| O||O |",
                                                @" \_||_/ " });

        public static Tile Partial { get; } =
            new Tile(
                new string[Config.Tile.Height] {@"        ",
                                                @"  ____  ",
                                                @" /|  |\ ",
                                                @"|O|  |O|",
                                                @" \|__|/ " });

        public static Tile Open { get; } =
            new Tile(
                new string[Config.Tile.Height] {@"        ",
                                                @"  ____  ",
                                                @" /    \ ",
                                                @"||    ||",
                                                @" \____/ " });
    }
}
