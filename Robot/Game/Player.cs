using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    /// <summary>
    /// Player on the map
    /// </summary>
    public abstract class Player
    {
        /// <summary>
        /// The Tile the player will appear as on the screen.
        /// </summary>
        public Tile Tile { get; protected set; }

        protected abstract Tile TileUp { get; }
        protected abstract Tile TileDown { get; }
        protected abstract Tile TileLeft { get; }
        protected abstract Tile TileRight { get; }

        /// <summary>
        /// Direction the player is facing on the map.
        /// </summary>
        protected Direction Direction { get; set; }

        /// <summary>
        /// Square the player current occupies.
        /// </summary>
        public Square CurrentSquare { get; private set; }

        public Player(Square startSquare, Tile startTile)
        {
            Tile = startTile;

            CurrentSquare = startSquare;
            CurrentSquare.EnterSquare(this);
        }

        private void Move(Direction direction)
        {
            Square destination = CurrentSquare.Neighbor(direction);

            if (destination != null)
            {
                if (destination.Name == "Door")
                    Screen.Print("You found the door!");

                if (destination.Player != null)
                    Screen.Print("You found a friend!");

                if (destination.EnterSquare(this))
                {
                    CurrentSquare.LeaveSquare(this);
                    CurrentSquare = destination;
                }
            }
        }

        /// <summary>
        /// Move the player in the direction they are facing one square.
        /// </summary>
        public void MoveForward()
        {
            Move(this.Direction);
        }

        /// <summary>
        /// Turn the player right.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void TurnRight()
        {
            switch (this.Direction)
            {
                case Direction.Right: 
                    this.Direction = Direction.Down;
                    this.Tile = TileDown;
                    break;
                case Direction.Down: 
                    this.Direction = Direction.Left;
                    this.Tile = TileLeft;
                    break;
                case Direction.Left: 
                    this.Direction = Direction.Up;
                    this.Tile = TileUp;
                    break;
                case Direction.Up: 
                    this.Direction = Direction.Right;
                    this.Tile = TileRight;
                    break;
                default: throw new Exception("Unknown direction.");
            }

            this.CurrentSquare.Draw();
        }
    }
}
