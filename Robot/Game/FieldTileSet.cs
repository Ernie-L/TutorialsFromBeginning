namespace Game
{
    public static class FieldTileSet
    {
        public static Tile Grass { get; } =
            new Tile(
                new string[Config.Tile.Height] {@"/\|\/|/|",
                                                @"\|/\/|/\",
                                                @"|/\|/|\/",
                                                @"\/|//\|\",
                                                @"\\/|\//\" },
        ConsoleColor.DarkGreen,
        ConsoleColor.DarkYellow);

        public static Tile Water { get; } =
            new Tile(
                new string[Config.Tile.Height] {@"~/~~/~~~",
                                                @"~~/~~~~~",
                                                @"~/~~~~~/",
                                                @"/~~/~~/~",
                                                @"~/~~/~~~" },
                ConsoleColor.DarkCyan,
                ConsoleColor.White);


        public static Tile Tree { get; } =
            new Tile(
                new string[Config.Tile.Height] {@"   ()   ",
                                                @"  ()()  ",
                                                @" ()()() ",
                                                @"   | |  ",
                                                @"   | |  " },
        ConsoleColor.DarkGreen,
        ConsoleColor.White);
    }
}
