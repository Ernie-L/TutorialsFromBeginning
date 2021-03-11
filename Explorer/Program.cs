using System;

namespace Explorer
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Goal: 1. Abstract class of Square with different concrete 
            ///           classes like land and water.
            ///        2. Have the map store arrays of squares.
            ///        3. Have the player move around the new map.
            ///        
            //// Quiz: Add a new type of square... without changing code outside the Map.cs file.

            Map map = new Map();
            map.Draw();

            Player player = new Player(map, 4, 5);
            player.Draw();

            bool play = true;

            Console.WriteLine("Where do you want to go? W,A,S,D, or E to exit");

            while (play)
            {
                char key = Screen.GetKeyPress(
                    new char[] { 'W', 'A', 'S', 'D', 'E' });

                char keyUpper = char.ToUpper(key);

                if ('E' == keyUpper)
                {
                    play = false;
                }
                else if ('W' == keyUpper)
                {
                    player.Up();
                }
                else if ('A' == keyUpper)
                {
                    player.Left();
                }
                else if ('S' == keyUpper)
                {
                    player.Down();
                }
                else if ('D' == keyUpper)
                {
                    player.Right();
                }
            }
        }
    }
}
