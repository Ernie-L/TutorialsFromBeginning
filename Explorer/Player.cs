using System;
using System.Collections.Generic;
using System.Text;

namespace Explorer
{
    public class Player
    {
        public char Display { get; }

        private Map _map;

        public int X { get; private set; }
        public int Y { get; private set; }

        public Player(Map map, int x, int y)
        {
            _map = map;
            X = x;
            Y = y;

            Display = 'P';
        }

        public void Draw()
        {
            Screen.WriteAt(Display, X, Y);
        }

        public void Up()
        {
            // what's unsafe about this if?
            if(_map.Squares[X, Y - 1].Passable)
            {
                _map.Draw(X, Y);
                Y--;
                Draw();
            }
        }

        public void Down()
        {
            if (_map.Squares[X, Y + 1].Passable)
            {
                _map.Draw(X, Y);
                Y++;
                Draw();
            }
        }

        public void Right()
        {
            if (_map.Squares[X + 1, Y].Passable)
            {
                _map.Draw(X,Y);
                X++;
                Draw();
            }
        }

        public void Left()
        {
            if (_map.Squares[X - 1, Y].Passable)
            {
                _map.Draw(X, Y);
                X--;
                Draw();
            }
        }
    }
}
