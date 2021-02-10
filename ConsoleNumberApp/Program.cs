using System;

namespace DrawingWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //// From Console Docs:
            //ColorSample.Run();          // see GetKeyPress() for good single key feedback.
            ConsoleSample.Run();

            //// Test Programs:
            //ArrayDrawing.Run();

            //ReadLine(); ;
            //HellowWorld();
            //Add();
            //Array();
            //PrintDigits();
            //GuessMyNumber();
            //ParseANumber();
        }

        static void HellowWorld()
        {
            Console.WriteLine("Hello World!");
        }

        static void ReadLine()
        {
            Console.WriteLine("Hello World!");

            string s = Console.ReadLine();

            Console.WriteLine("you said " + s);
        }

        // string +

        static void Add()
        {
            Console.WriteLine("Enter a character:");
            int i = Console.Read();     // only reads a single charaters... will leave "\n" and more on the line.
            Console.ReadLine();

            Console.WriteLine("You input:");
            Console.WriteLine(i);
        }

        static void Array()
        {
            char[] array = new char[] { 'A', 'B', 'C' };
            Console.WriteLine(array);

            char a = array[0];
            char b = array[1];
            char c = array[2];

            Console.Write("A is:");
            Console.WriteLine(a);

            //int counter = 0;
            //while (counter <= array.Length)         // will throw... why?
            //{
            //    Console.Write("Next Value:");
            //    Console.WriteLine(array[counter]);

            //    counter = counter + 1;
            //}
        }

        static void ArrayWalk()
        {
            Console.WriteLine("Please enter a name: ");
            string name = Console.ReadLine();

            // string is array of char

            int counter = 0;
            while (counter <= name.Length)
            {
                Console.Write("Next letter:");
                Console.WriteLine(name[counter]);

                counter = counter + 1;
            }
        }

        static void PrintDigitsShell()
        {
            // enter a number 

            // loop through each character

            // print each charater
        }

        static void PrintDigits()
        {
            Console.WriteLine("Please enter a number: ");
            string numberString = Console.ReadLine();

            int position = 0;

            while (position < numberString.Length)
            {
                char c = numberString[position];
                int digit = (int)c;     // don't change it, treat it like an int.
                digit = digit - 48;     // we know: "4" = 52, "5" = 53

                Console.WriteLine("Digit is:");
                Console.WriteLine(digit);

                position = position + 1;
            }
        }

        static int CharToInt(char c)
        {
            int digit = (int)c;     // don't change it, treat it like an int.
            digit = digit - 48;     // we know: "4" = 52, "5" = 53
            return digit;
        }

        static void PrintDigits2()
        {
            Console.WriteLine("Please enter a number: ");
            string numberString = Console.ReadLine();

            int position = 0;

            while (position < numberString.Length)
            {
                int digit = CharToInt(numberString[position]);

                Console.WriteLine("Digit is:");
                Console.WriteLine(digit);

                position = position + 1;
            }
        }

        static void ParseANumber()
        {
            Console.WriteLine("Please enter a number: ");
            string numberString = Console.ReadLine();
            int numberStringLength = numberString.Length;

            double digitePlaceHolderD = Math.Pow(10, numberStringLength - 1);
            int digitPlaceHolder = Convert.ToInt32(digitePlaceHolderD);
            int final = 0;
            int position = 0;

            while (position < numberStringLength)
            {
                int digit = CharToInt(numberString[position]);

                //int digit = int.Parse(c.ToString());

                final = final + digit * digitPlaceHolder;

                digitPlaceHolder = digitPlaceHolder / 10;
                position = position + 1;
            }

            Console.WriteLine("Final number is ");
            Console.WriteLine(final);
        }

        static void GuessMyNumber()
        {
            Random r = new Random();
            int winningNumber = r.Next(0, 100);     // pick a winning number between 0 and 100
            bool found = false;

            while (!found)
            {
                Console.WriteLine("Please guess a number: ");
                string guess = Console.ReadLine();

                int numberGuess = int.Parse(guess);

                if (numberGuess == winningNumber)
                {
                    found = true;
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("Nope!");   // how to help more???
                }
            }
        }
    }
}
