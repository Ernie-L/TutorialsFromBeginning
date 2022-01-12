using System;
using System.Collections.Generic;
using System.Text;

namespace Robot
{
    /// <summary>
    /// Player on the map
    /// </summary>
    public class Player
    {
        /// <summary>
        /// The Tile the player will appear as on the screen.
        /// </summary>
        public Tile Tile { get; private set; }

        /// <summary>
        /// Direction the player is facing on the map.
        /// </summary>
        private Direction Direction { get; set; }

        /// <summary>
        /// Square the player current occupies.
        /// </summary>
        public Square CurrentSquare { get; private set; }

        public Player(Square square)
        {
            Tile = RobotTileSet.Robot.Right;
            Direction = Direction.Right;

            CurrentSquare = square;
            CurrentSquare.EnterSquare(this);
        }

        private void Move(Direction direction)
        {
            Square destination = CurrentSquare.Neighbor(direction);

            if (destination != null)
            {
                if (destination.Name == "Door")
                    Screen.Print("You found the door!");

                if (destination.Passable)
                {
                    CurrentSquare.LeaveSquare(this);

                    CurrentSquare = destination;
                    CurrentSquare.EnterSquare(this);
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
                    this.Tile = RobotTileSet.Robot.Down;
                    break;
                case Direction.Down: 
                    this.Direction = Direction.Left;
                    this.Tile = RobotTileSet.Robot.Left;
                    break;
                case Direction.Left: 
                    this.Direction = Direction.Up;
                    this.Tile = RobotTileSet.Robot.Up;
                    break;
                case Direction.Up: 
                    this.Direction = Direction.Right;
                    this.Tile = RobotTileSet.Robot.Right;
                    break;
                default: throw new Exception("Unknown direction.");
            }

            this.CurrentSquare.Draw();
        }
    }
}
