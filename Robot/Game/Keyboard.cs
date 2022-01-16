using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Keyboard
    {
        public static void PlayLoop(Robot r1, Robot r2 = null)
        {
            bool play = true;

            Console.WriteLine("Where do you want to go? W,A,S,D, or E to exit");

            while (play)
            {
                char key = Screen.GetKeyPress(
                    new char[] { 'W', 'A', 'S', 'D', 'E', 'I', 'L', 'K', 'J' });

                char keyUpper = char.ToUpper(key);

                if ('E' == keyUpper)
                {
                    play = false;
                }
                else if ('W' == keyUpper)
                {
                    r1.MoveForward();
                }
                else if ('A' == keyUpper)
                {
                    r1.TurnRight();
                }
                else if ('S' == keyUpper)
                {
                    //player.Move(Direction.Down);
                }
                else if ('D' == keyUpper)
                {
                    r1.TurnRight();
                }

                if (r2 is not null)
                {
                    if ('I' == keyUpper)
                    {
                        r2.MoveForward();
                    }
                    else if ('L' == keyUpper)
                    {
                        r2.TurnRight();
                    }
                    else if ('K' == keyUpper)
                    {
                        //player.Move(Direction.Down);
                    }
                    else if ('J' == keyUpper)
                    {
                        r2.TurnRight();
                    }
                }
            }
        }
    }
}
