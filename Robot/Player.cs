using System;
using System.Collections.Generic;
using System.Text;

namespace Robot
{
    public class Player
    {
        public string[] Display { get; private set; }

        public Direction Direction { get; private set; }

        public Square CurrentSquare { get; private set; }

        public Player(Square square)
        {
            Display = Tile.Robot.Right;
            Direction = Direction.Right;

            CurrentSquare = square;
            CurrentSquare.EnterSquare(this);
        }

        private void Move(Direction direction)
        {
            Square destination = CurrentSquare.Neighbor(direction);

            if (destination != null && destination.Passable)
            {
                CurrentSquare.LeaveSquare(this);
               
                CurrentSquare = destination;
                CurrentSquare.EnterSquare(this);
            }
        }

        public void MoveForward()
        {
            Move(this.Direction);
        }

        public void Turn()
        {
            switch (this.Direction)
            {
                case Direction.Right: 
                    this.Direction = Direction.Down;
                    this.Display = Tile.Robot.Down;
                    break;
                case Direction.Down: 
                    this.Direction = Direction.Left;
                    this.Display = Tile.Robot.Left;
                    break;
                case Direction.Left: 
                    this.Direction = Direction.Up;
                    this.Display = Tile.Robot.Up;
                    break;
                case Direction.Up: 
                    this.Direction = Direction.Right;
                    this.Display = Tile.Robot.Right;
                    break;
                default: throw new Exception("Unknown direction.");
            }

            this.CurrentSquare.Draw();
        }
    }
}
