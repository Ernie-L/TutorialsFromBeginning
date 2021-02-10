using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingWithArrays
{
    public static class ArrayDrawing
    {
        public static void Run()
        {
            char[,] picture = new char[,] {
                {' ', '/','\\','/','\\','/','\\','/','\\','/','\\',' '},
                {'/', ' ',' ','.',' ',' ',' ','.',' ',' ','\\','\\'},
                {'|', ' ',' ',' ',' ','>',' ',' ',' ',' ',' ','|'},
                {' ', '\\',' ','\\','_','_','_','_','/',' ','/',' '}, };

            DrawGrid(picture);

            bool edit = true;
            while (edit)
            {
                Edit(picture);
                Draw(picture);

                Console.WriteLine("Would you like to edit again? [y/n]");
                string again = Console.ReadLine();

                if (again.ToLower() == "n")
                    edit = false;
            }

            Console.WriteLine("All done --- as code:");
            DrawAsCode(picture);

            //Console.WriteLine("hit enter");
            //Console.ReadLine();
        }
        
        public static void Edit(char[,] picture)
        {
            Console.WriteLine("Enter a row:");
            int row = int.Parse(Console.ReadLine());
            // need error checking... row in bounds.

            Console.WriteLine("Enter a column:");
            int column = int.Parse(Console.ReadLine());
            // need error checking... column in bounds.

            Console.WriteLine("What change it to:");
            string edit = Console.ReadLine();

            picture[column, row] = edit[0];
        }

        public static void Draw(char[,] picture)
        {
            for(int row=0; row <picture.GetLength(0); row++)
            {
                for (int column = 0; column < picture.GetLength(1); column++)
                {
                    Console.Write(picture[row, column]);
                }
                Console.WriteLine();
            }
        }

        public static void DrawGrid(char[,] picture)
        {
            for (int column = 0; column < picture.GetLength(1); column++)
            {
                Console.Write(column);

                // column #10 and higher throw it off the output...
            }
            Console.WriteLine();

            for (int row = 0; row < picture.GetLength(0); row++)
            {
                Console.Write(row);

                for (int column = 0; column < picture.GetLength(1); column++)
                {
                    Console.Write(picture[row, column]);
                }
                Console.WriteLine();
            }
        }

        public static void DrawAsCode(char[,] picture)
        {
            Console.WriteLine("{");
            for (int row = 0; row < picture.GetLength(0); row++)
            {
                Console.Write("{");
                for (int column = 0; column < picture.GetLength(1); column++)
                {
                    Console.Write("'" + picture[row, column] + "',");
                }
                Console.WriteLine("},");
            }
            Console.WriteLine("};");
        }
    }
}
