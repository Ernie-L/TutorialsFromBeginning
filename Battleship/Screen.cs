using System;

namespace Battleship
{
    public static class Screen
    {
        public static Char GetKeyPress(String msg, Char[] validChars)
        {
            ConsoleKeyInfo keyPressed;
            bool valid = false;

            Console.WriteLine();
            do
            {
                Console.Write(msg);
                keyPressed = Console.ReadKey();
                Console.WriteLine();
                if (Array.Exists(validChars, ch => ch.Equals(Char.ToUpper(keyPressed.KeyChar))))
                    valid = true;
            } while (!valid);
            return keyPressed.KeyChar;
        }

        public static void WriteAt(int i, int x, int y)
        {
            if (i > 9 || i < 0)
                throw new ArgumentException("Int cannot be negative or more than one digit.");

            WriteAt(i.ToString()[0], x, y);
        }

        public static void WriteAt(string s, int x, int y)
        {
            if (s == null)
                throw new NullReferenceException();
            if (s.Length < 1)
                throw new ArgumentException("string cannot be empty.");

            WriteAt(s[0], x, y);
        }

            public static void WriteAt(char s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(x, y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);

                throw new Exception("Board wrote to invalid coordiates.", e);
            }
        }

        public static void Clear()
        {
            Console.Clear();
        }
    }
}
