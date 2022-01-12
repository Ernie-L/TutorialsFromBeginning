using System;
using System.Collections.Generic;
using System.Text;

namespace Explorer
{
    public class Player
    {
        public char Display { get; }

        public Square CurrentSquare { get; private set; }

        public Player(Square square)
        {
            Display = 'O';

            CurrentSquare = square;
            CurrentSquare.EnterSquare(this);
        }

        public void Move(Direction direction)
        {
            Square destination = CurrentSquare.Neighbor(direction);

            if (destination != null && destination.Passable)
            {
                CurrentSquare.LeaveSquare(this);
               
                CurrentSquare = destination;
                CurrentSquare.EnterSquare(this);
            }
        }
    }
}
