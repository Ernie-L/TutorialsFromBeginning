using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Keyboard
    {
        public static bool PlayLoop(Player r1, Player r2 = null)
        {
            bool exit = false;
            bool play = true;
            GameEvents events = GameEvents.GetGameEvents();

            Console.WriteLine("Where do you want to go? W,A,S,D, or E to exit");

            while (play)
            {
                char key = Screen.GetKeyPress(
                    new char[] { 'W', 'A', 'S', 'D', 'E', 'I', 'L', 'K', 'J' });

                char keyUpper = char.ToUpper(key);

                switch (keyUpper)
                {
                    case 'E': play = false; exit = true; break;
                    case 'W': r1.MoveForward(); break;
                    case 'A': r1.TurnRight(); break;
                    //case 'S': r1.MoveForward(); break;
                    case 'D': r1.TurnRight(); break;
                }

                if (r2 is not null)
                {
                    switch (keyUpper)
                    {
                        case 'I': r2.MoveForward(); break;
                        case 'L': r2.TurnRight(); break;
                        //case 'K': r1.TurnRight(); break;
                        case 'J': r2.TurnRight(); break;
                    }
                }

                if (!events.IsEmpty)
                    play = false;
            }

            return exit;
        }
    }
}
