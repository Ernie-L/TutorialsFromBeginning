using System;

namespace Explorer
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////
            /// Object design:
            /// The map contains squares and "knows" how to draw its squares
            /// THe player knows how to move around the map.
            /// The map does NOT "know about" the player.

            Map map = new Map();

            Player player = new Player(map.Squares[0, 0]);
            map.Draw();

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
                    player.Move(Direction.Up);
                }
                else if ('A' == keyUpper)
                {
                    player.Move(Direction.Left);
                }
                else if ('S' == keyUpper)
                {
                    player.Move(Direction.Down);
                }
                else if ('D' == keyUpper)
                {
                    player.Move(Direction.Right);
                }
            }
        }
    }
}