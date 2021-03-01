using System;

namespace Explorer
{
    /// <summary>
    /// Utilities for the System.Console class.
    /// </summary>
    public static class Screen
    {
        /// <summary>
        /// Takes an array of characters. When any one of the allowed characters is pressed, 
        /// it returns that character. Will not return until a valid charater is pressed.
        /// </summary>
        /// <param name="validChars">Array of valid characters</param>
        /// <returns>Character that was pressed</returns>
        public static Char GetKeyPress(Char[] validChars)
        {
            ConsoleKeyInfo keyPressed;
            bool valid = false;

            do
            {
                keyPressed = Console.ReadKey();
                if (Array.Exists(validChars, ch => ch.Equals(Char.ToUpper(keyPressed.KeyChar))))
                {
                    valid = true;
                }
            } while (!valid);
            return keyPressed.KeyChar;
        }

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

                throw new Exception($"Writing to the console at {x},{y} failed.", e);
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

        public static void SetCursorPosition(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }
    }
}
