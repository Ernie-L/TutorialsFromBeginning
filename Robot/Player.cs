using System;
using System.Collections.Generic;
using System.Text;

namespace Robot
{
    public class Player
    {
        public Tile Tile { get; private set; }

        public Direction Direction { get; private set; }

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
