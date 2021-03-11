using System;
using System.Collections.Generic;
using System.Text;

namespace Explorer
{
    public class Player
    {
        public char Display { get; }

        private Square _square;

        public Player(Square square)
        {
            _square = square;
            Display = 'P';
        }

        public void Move(Direction direction)
        {
            Square destination = _square.Check(direction);

            if (destination != null)
            {
                _square.Player = null;
                _square.Draw();

                _square = destination;
                _square.Player = this;
                _square.Draw();
            }
        }
    }
}
