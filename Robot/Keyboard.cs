using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    internal class Keyboard
    {
        public static void PlayLoop(Player p)
        {
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
                    p.MoveForward();
                }
                else if ('A' == keyUpper)
                {
                    p.TurnRight();
                }
                else if ('S' == keyUpper)
                {
                    //player.Move(Direction.Down);
                }
                else if ('D' == keyUpper)
                {
                    p.TurnRight();
                }
            }
        }
    }
}
