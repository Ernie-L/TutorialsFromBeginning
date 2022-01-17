
namespace Robot
{
    public static class StarterTileset
    {
        public static Tile Woodfloor { get; } =
     new Tile(
         new string[Config.Tile.Height] { @"______|_",
                                            @"_____|__",
                                            @"___|____",
                                            @"_____|__",
                                            @"__|_____" },
         ConsoleColor.DarkRed,
         ConsoleColor.White);
        public static Tile Wall { get; } =
            new Tile(
                new string[Config.Tile.Height] { @"__|     ",
                                            @"__|     ",
                                            @"__|     ",
                                            @"__|     ",
                                            @"__|     " },
                ConsoleColor.Black,
                ConsoleColor.White);
        public static Tile Window { get; } =
            new Tile(
                new string[Config.Tile.Height] { @"________",
                                            @"|  |   |",
                                            @"|__|___|",
                                            @"|  |   |",
                                            @"|__|___|" },
                ConsoleColor.White,
                ConsoleColor.Black);
        public static Tile Table { get; } =
            new Tile(
                new string[Config.Tile.Height] { @"        ",
                                            @" ______ ",
                                            @"|      |",
                                            @"|______|",
                                            @"||    ||" },
                ConsoleColor.Black,
                ConsoleColor.White);
        public static Tile Road { get; } =
            new Tile(
                new string[Config.Tile.Height] { @"........",
                                            @"........",
                                            @"........",
                                            @"........",
                                            @"........" },
                ConsoleColor.Gray,
                ConsoleColor.Black);

        public static Tile BrickFloor { get; } =
     new Tile(
         new string[Config.Tile.Height] { @"______|_",
                                            @"_____|__",
                                            @"___|____",
                                            @"_____|__",
                                            @"__|_____" },
         ConsoleColor.DarkBlue,
         ConsoleColor.White);
    
    }
    
}
