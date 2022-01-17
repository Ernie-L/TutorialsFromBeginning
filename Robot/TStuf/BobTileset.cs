namespace Robot
{
    public static class BobTileset
    {
            public static Tile Up { get; } =
                new Tile(
                    new string[Config.Tile.Height] { @"        ",
                                                    @"  ( )   ",
                                                    @" /   \  ",
                                                    @"(/   \) ",
                                                    @"(_/ \_) " });

            public static Tile Right { get; } =
                new Tile(
                    new string[Config.Tile.Height] { @"        ",
                                                    @"   ( )  ",
                                                    @"   / |  ",
                                                    @"  (| |  ",
                                                    @"   [__) " });

            public static Tile Left { get; } =
                new Tile(
                    new string[Config.Tile.Height] { @"        ",
                                                    @"   ( )  ",
                                                    @"   | \  ",
                                                    @"   | |) ",
                                                    @"  (__]  " });

            public static Tile Down { get; } =
                new Tile(
                    new string[Config.Tile.Height] { @"        ",
                                                    @"  (^^)  ",
                                                    @" /   \  ",
                                                    @"(/   \) ",
                                                    @"(_/ \_) " });
        
    }
}
