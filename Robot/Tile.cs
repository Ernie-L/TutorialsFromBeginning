using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    internal class Tile
    {
        public static class config
        {
            public const int Width = 8;
            public const int Height = 5;
        };

        public static class Robot
        {
            public static string[] Up = new string[config.Height]
                                    { @" ______ ",
                                      @"/ v  v \",
                                      @"|------|",
                                      @"|      |",
                                      @"\______/"};


            public static string[] Right = new string[config.Height]
                                      { @" ______ ",
                                        @"/  |   \",
                                        @"|  |  <|",
                                        @"|  |  <|",
                                        @"\__|___/" };

            public static string[] Left = new string[config.Height]
                                      { @" ______ ",
                                        @"/   |  \",
                                        @"|>  |  |",
                                        @"|>  |  |",
                                        @"\___|__/" };

            public static string[] Down = new string[config.Height]
                                      { @" ______ ",
                                        @"/      \",
                                        @"|      |",
                                        @"|------|",
                                        @"\_^__^_/" };
        }

        public static string[] Grass = new string[config.Height]
                                    { @"/\|\/|/|",
                                      @"\|/\/|/\",
                                      @"|/\|/|\/",
                                      @"\/|//\|\",
                                      @"\\/|\//\" };

        public static string[] Water = new string[config.Height]
                                    {@"~/~~/~~~",
                                     @"~~/~~~~~",
                                     @"~/~~~~~/",
                                     @"/~~/~~/~",
                                     @"~/~~/~~~" };

        public static class Door
        {
            public static string[] Closed = new string[config.Height]
                                        { @"        ",
                                          @"  ____  ",
                                          @" / || \ ",
                                          @"| O||O |",
                                          @" \_||_/ " };

            public static string[] Partial = new string[config.Height]
                                        {  @"        ",
                                           @"  ____  ",
                                           @" /|  |\ ",
                                           @"|O|  |O|",
                                           @" \|__|/ " };

            public static string[] Open = new string[config.Height]
                                       {@"        ",
                                        @"  ____  ",
                                        @" /    \ ",
                                        @"||    ||",
                                        @" \____/ " };
        }
    }
}
