using System;
using System.Collections.Generic;
using System.Text;

namespace Explorer
{
    public class Player
    {
        public char Display { get; }

        private Square _currentSquare;

        public Player(Square square)
        {
            Display = 'O';

            _currentSquare = square;
            _currentSquare.EnterSquare(this);
        }

        public void Move(Direction direction)
        {
            Square destination = _currentSquare.Check(direction);

            if (destination != null)
            {
                _currentSquare.LeaveSquare();
               
                _currentSquare = destination;
                _currentSquare.EnterSquare(this);
            }
        }
    }
}
