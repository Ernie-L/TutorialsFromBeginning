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
            public static string Up = @" ______ " + "\n" +
                                      @"/ v  v \" + "\n" +
                                      @"|------|" + "\n" +
                                      @"|      |" + "\n" +
                                      @"\______/";

            public static string[] Up2 = new string[config.Height]
                                    { @" ______ " + "\n",
                                      @"/ v  v \" + "\n",
                                      @"|------|" + "\n",
                                      @"|      |" + "\n",
                                      @"\______/"};


            public static string[] Right = new string[config.Height]
                                      { @" ______ " + "\n" ,
                                        @"/  |   \" + "\n",
                                        @"|  |  <|" + "\n",
                                        @"|  |  <|" + "\n",
                                        @"\__|___/" };

            public static string Left = @" ______ " + "\n" +
                                        @"/   |  \" + "\n" +
                                        @"|>  |  |" + "\n" +
                                        @"|>  |  |" + "\n" +
                                        @"\___|__/";

            public static string Down = @" ______ " + "\n" +
                                        @"/      \" + "\n" +
                                        @"|      |" + "\n" +
                                        @"|------|" + "\n" +
                                        @"\_^__^_/";
        }

        public static string[] Grass = new string[config.Height]
                                    { @"/\|\/|/|" + "\n",
                                      @"\|/\/|/\" + "\n",
                                      @"|/\|/|\/" + "\n",
                                      @"\/|//\|\" + "\n",
                                      @"\\/|\//\" };

        public static string[] Water = new string[config.Height]
                                    {@"~/~~/~~~" + "\n",
                                     @"~~/~~~~~" + "\n",
                                     @"~/~~~~~/" + "\n",
                                     @"/~~/~~/~" + "\n",
                                     @"~/~~/~~~" };

        public static class Door
        {
            public static string Closed = @"        " + "\n" +
                                          @"  ____  " + "\n" +
                                          @" / || \ " + "\n" +
                                          @"| O||O |" + "\n" +
                                          @" \_||_/ ";

            public static string Partial = @"        " + "\n" +
                                           @"  ____  " + "\n" +
                                           @" /|  |\ " + "\n" +
                                           @"|O|  |O|" + "\n" +
                                           @" \|__|/ ";

            public static string Open = @"        " + "\n" +
                                        @"  ____  " + "\n" +
                                        @" /    \ " + "\n" +
                                        @"||    ||" + "\n" +
                                        @" \____/ ";
        }
    }
}
