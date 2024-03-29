﻿using Game;
using Tiles;

namespace Squares
{
    public abstract class Square
    {
        public abstract Tile Tile { get; }
        public abstract string Name { get; }
        public abstract bool Passable { get; }

        private Player _player;

        public Player Player
        {
            get { return _player; }
            set { _player = value; Draw(); }
        }

        public Square Right { get; set; }
        public Square Left { get; set; }
        public Square Up { get; set; }
        public Square Down { get; set; }

        private int X { get; }
        private int Y { get; }

        public Square(int x, int y)
        {
            X = x;
            Y = y;
        }

        public virtual bool EnterSquare(Player player)
        {
            if (!Passable)
                return false;
            if (Player != null)
                return false;

            Player = player;
            Draw();
            return true;
        }

        public virtual void LeaveSquare(Player player)
        {
            if (Player != player)
                throw new Exception("Player can't leave the square bucause they aren't in the square.");

            Player = null;
            Draw();
        }

        public virtual void Draw()
        {
            Tile tile = null;

            if (Player != null)
                tile = Player.Tile;
            else
                tile = this.Tile;

            ConsoleColor originalBackground = Console.BackgroundColor;
            ConsoleColor originalForeground = Console.ForegroundColor;

            Console.BackgroundColor = tile.BackgroundColor;
            Console.ForegroundColor = tile.ForegroundColor;

            int startingX = X * Config.Tile.Width;
            int startingY = Y * Config.Tile.Height;

            if (tile.Display.Length != Config.Tile.Height)
                throw new Exception($"Title must be {Config.Tile.Height} high.");

            for (int y=0; y< Config.Tile.Height; y++)
            {
                if (tile.Display[y].Length < Config.Tile.Width)
                    throw new Exception($"Tile must be at least 5 {Config.Tile.Width} wide.");

                for (int x=0; x< Config.Tile.Width; x++)
                {
                    Screen.WriteAt(tile.Display[y][x], startingX + x , startingY + y);
                }
            }

            Console.BackgroundColor = originalBackground;
            Console.ForegroundColor = originalForeground;

            //Screen.SetCursorPosition(0, Tile.config.Height + 2);
        }

        /// <summary>
        /// Returns the neighboring square on the map from the given direction.
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public virtual Square Neighbor(Direction direction)
        {
            Square neighbor;

            if (direction == Direction.Up) neighbor = Up;
            else if (direction == Direction.Down) neighbor = Down;
            else if (direction == Direction.Left) neighbor = Left;
            else if (direction == Direction.Right) neighbor = Right;
            else 
                throw new Exception("Don't know where to move.");

            return neighbor;    // can be null if off the map.
        }
    }
}