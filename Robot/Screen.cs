using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    internal class Screen
    {
        /// <summary>
        /// Takes an array of characters. When any one of the allowed characters is pressed, 
        /// it returns that character. Will not return until a valid charater is pressed.
        /// </summary>
        /// <param name="validChars">Array of valid characters</param>
        /// <returns>Character that was pressed</returns>
        public static Char GetKeyPress(char[] validChars)
        {
            char keyPressed;
            bool valid = false;

            do
            {
                keyPressed = Console.ReadKey().KeyChar;
                char keyUpper = char.ToUpper(keyPressed);

                for (int i = 0; i < validChars.Length; i++)
                {
                    if (keyUpper == validChars[i])
                        valid = true;
                }
            } while (!valid);
            return keyPressed;
        }

        /// <summary>
        /// Writes the input char to the Console coordinates.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void WriteAt(char s, int x, int y)
        {
            int originalX = Console.CursorLeft;
            int originalY = Console.CursorTop;

            try
            {
                Console.SetCursorPosition(x, y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);

                throw new Exception($"Writing to the console at {x},{y} was out of range and failed.", e);
            }
            finally
            {
                Console.SetCursorPosition(originalX, originalY);
            }
        }

        public static void Clear()
        {
            Console.Clear();
        }

        /// <summary>
        /// Moves the Console cursor to input coordinates. The next Console write will begin from those coordinates.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void SetCursorPosition(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }
    }
}
